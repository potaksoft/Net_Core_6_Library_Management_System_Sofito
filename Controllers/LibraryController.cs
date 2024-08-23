using Library_Apı_Sysytem.Data;
using Library_Apı_Sysytem.Entities;
using Library_Apı_Sysytem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library_Apı_Sysytem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ApiDbContext _context;
        private readonly EmailService _emailService;
        private readonly JwtService _jwtService;


        public LibraryController(ApiDbContext context, EmailService emailService, JwtService jwtService)
        {
            _context = context;
            _emailService = emailService;
            _jwtService = jwtService;
        }
        [HttpPost("Register")]
        public ActionResult Register(User user)
        {
            user.AccountStatus = AccountStatus.UNAPROOVED;
            user.UserType = UserType.MEMBER;
            user.CreatedOn = DateTime.Now;

            _context.Users.Add(user);
            _context.SaveChanges();

            const string subject = "Hesap olustu";
            var body = $"Merhaba Sayın {user.FirstName} {user.LastName} uyelıgınız aktif edilmistir";

            _emailService.SendEmail(user.Email, subject, body);

            return Ok(@"Kayıt oldugunuz icin Tesekkurler. 
                       Hesabınız onay için gönderildi. 
                       Onaylandıktan sonra bir e-posta alacaksınız."
                     );
        }
        [HttpGet("Login")]
        public ActionResult Login(string email, string password)
        {
            if (_context.Users.Any(u => u.Email.Equals(email) && u.Password.Equals(password)))
            {
                var user = _context.Users.Single(user => user.Email.Equals(email) && user.Password.Equals(password));

                if (user.AccountStatus == AccountStatus.UNAPROOVED)
                {
                    return Ok("unapproved");
                }

                if (user.AccountStatus == AccountStatus.BLOCKED)
                {
                    return Ok("blocked");
                }

                return Ok(_jwtService.GenerateToken(user));
            }
            return Ok("not found");
        }

        [HttpGet("GetBooks")]
        public ActionResult GetBooks()
        {
            if (_context.Books.Any())
            {

                return Ok(_context.Books.Include(b => b.BookCategory).ToList());
            }
            return NotFound();
        }
        [HttpPost("OrderBook")]
        public ActionResult OrderBook(string userId, int bookId)
        {
            var user = _context.Users.Find(userId);
            if (user is not null)
            {
                if (user.UserType == UserType.MEMBER || user.UserType == UserType.EMPLOYEE)
                {
                    var canOrder = _context.Orders.Count(o => o.UserId == userId && !o.Returned) < 3;//3ten fazla kitap kiralayamaz 

                    if (canOrder)
                    {
                        _context.Orders.Add(new()
                        {
                            UserId = userId,
                            BookId = bookId,
                            OrderDate = DateTime.Now,
                            ReturnDate = null,
                            Returned = false,
                            FinePaid = 0
                        });

                        var book = _context.Books.Find(bookId);
                        if (book is not null)
                        {
                            book.Ordered = true;
                        }


                        _context.SaveChanges();
                        return Ok("ordered");
                    }

                    return Ok("cannot order");
                }
                return Unauthorized();
            }
            return NotFound();
        }
        [HttpGet("GetOrdersOFUser")]
        public ActionResult GetOrdersOFUser(string userId)
        {
            var orders = _context.Orders
              .Include(o => o.Book)
              .Include(o => o.User)
              .Where(o => o.UserId == userId)
              .ToList();
            if (orders.Any())
            {
                return Ok(orders);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost("AddCategory")]

        public ActionResult AddCategory(string userId, BookCategory bookCategory)
        {
            var user = _context.Users.Find(userId);
            if (user is not null)
            {
                if (user.UserType == UserType.EMPLOYEE)
                {
                    var exists = _context.BookCategories.Any(bc => bc.Category == bookCategory.Category && bc.SubCategory == bookCategory.SubCategory);
                    if (exists)
                    {
                        return Ok("cannot insert");
                    }
                    else
                    {
                        _context.BookCategories.Add(new()
                        {
                            Category = bookCategory.Category,
                            SubCategory = bookCategory.SubCategory
                        });
                        _context.SaveChanges();
                        return Ok("INSERTED");
                    }
                }
                return Unauthorized();

            }
            return NotFound();
        }
        [HttpGet("GetCategories")]
        public ActionResult GetCategories()
        {
            var categories = _context.BookCategories.ToList();
            if (categories.Any())
            {
                return Ok(categories);
            }
            return NotFound();
        }
        [HttpPost("AddBook")]
        public ActionResult AddBook(string userId, Book book)
        {
            var user = _context.Users.Find(userId);
            if (user is not null)
            {
                if (user.UserType == UserType.EMPLOYEE)
                {
                    book.BookCategory = null;
                    _context.Books.Add(book);
                    _context.SaveChanges();
                    return Ok("inserted");

                }
                return Unauthorized();
            }
            return NotFound();


        }
        [HttpDelete("DeleteBook")]
        public ActionResult DeleteBook(string userId, int id)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                if (user.UserType == UserType.EMPLOYEE)
                {
                    var exists = _context.Books.Any(b => b.Id == id);
                    if (exists)
                    {
                        var book = _context.Books.Find(id);
                        _context.Books.Remove(book!);
                        _context.SaveChanges();
                        return Ok("deleted");
                    }
                    return NotFound();
                }
                return Unauthorized();
            }
            return NotFound();
        }
        [HttpPut("DeleteUser")]
        public ActionResult DeleteUser(string userId, string memberId)
        {
            var user = _context.Users.Find(userId);


            if (user.UserType == UserType.EMPLOYEE)
            {
                var member = _context.Users.Find(memberId);
                if (member != null)
                {
                    member.UserType = UserType.NONE;
                    _context.SaveChanges();
                    return Ok("deleted");
                }
                return NotFound();
            }
            return Unauthorized();


        }
        [HttpGet("ReturnBook")]
        public ActionResult ReturnBook(string userId, int bookId, int fine)
        {
            var order = _context.Orders.SingleOrDefault(o => o.UserId == userId && o.BookId == bookId);
            if (order is not null)
            {
                order.Returned = true;
                order.ReturnDate = DateTime.Now;
                order.FinePaid = fine;

                var book = _context.Books.Single(b => b.Id == order.BookId);
                book.Ordered = false;

                _context.SaveChanges();

                return Ok("returned");
            }
            return Ok("not returned");
        }
        [HttpGet("GetUsers")]
        public ActionResult GetUsers(string userId)
        {
            var user = _context.Users.Find(userId);
            if (user is not null)
            {
                if (user.UserType == UserType.EMPLOYEE)
                {
                    return Ok(_context.Users.ToList());
                }
                return Unauthorized();
            }
            return NotFound();

        }
        [HttpGet("ApproveRequest")]
        public ActionResult ApproveRequest(string memberId, string userId)
        {
            var user = _context.Users.Find(userId);
            if (user is not null)
            {
                if (user.UserType == UserType.EMPLOYEE)
                {
                    var member = _context.Users.Find(memberId);

                    if (member is not null)
                    {
                        if (member.AccountStatus == AccountStatus.UNAPROOVED)
                        {
                            member.AccountStatus = AccountStatus.ACTIVE;
                            _context.SaveChanges();

                            _emailService.SendEmail(member.Email,
                                "Hesap Onaylandı",
                                $"Merhaba {member.FirstName} {member.LastName} hesabınız yonetici tarafından onaylandı.Hesaba giris yapablirsiniz"

                            );

                            return Ok("Onaylandı");
                        }
                    }

                    return Ok("Onaylanmadı");
                }
                return Unauthorized();
            }
            return NotFound();


        }
        [HttpGet("GetOrders")]
        public ActionResult GetOrders(string userId)
        {
            var user = _context.Users.Find(userId);
            if (user is not null)
            {
                if (user.UserType == UserType.EMPLOYEE)
                {
                    var orders = _context.Orders.Include(o => o.User).Include(o => o.Book).ToList();
                    if (orders.Any())
                    {
                        return Ok(orders);
                    }
                    else
                    {
                        return NotFound();
                    }

                }
                return Unauthorized();
            }
            return NotFound();


        }
        [HttpGet("SendEmailForPendingReturns")]
        public ActionResult SendEmailForPendingReturns(string employeeId)
        {
            var employee = _context.Users.Find(employeeId);
            if (employee is not null)
            {
                if (employee.UserType == UserType.EMPLOYEE)
                {
                    var orders = _context.Orders
                           .Include(o => o.Book)
                           .Include(o => o.User)
                           .Where(o => !o.Returned)
                           .ToList();

                    var emailsWithFine = orders.Where(o => DateTime.Now > o.OrderDate.AddDays(10)).ToList();
                    emailsWithFine.ForEach(x => x.FinePaid = (DateTime.Now - x.OrderDate.AddDays(10)).Days * 50);

                    var firstFineEmails = emailsWithFine.Where(x => x.FinePaid == 50).ToList();
                    firstFineEmails.ForEach(x =>
                    {
                        var body = $"Merhaba  {x.User?.FirstName} {x.User?.LastName} dün {x.Book?.Title} " +
                        $"kitabını getirmek icin son gundu.Bugunden itibaren gunluk 50 lira ceza gelecektir" +
                        $"Lutfen en kısa zamanda geri getirin "
                        ;
                        _emailService.SendEmail(x.User!.Email, "Return Overdue", body);
                    });

                    var regularFineEmails = emailsWithFine.Where(x => x.FinePaid > 50 && x.FinePaid <= 500).ToList();
                    regularFineEmails.ForEach(x =>
                    {
                        var regularFineEmailsBody = $"Merhaba  {x.User?.FirstName} {x.User?.LastName}  {x.FinePaid} " +
                        $"tutarında kitap cezanız vardır.Lutfen en kısa zamanda odeyin";


                        _emailService.SendEmail(x.User?.Email!, "Fine To Pay", regularFineEmailsBody);
                    });

                    var overdueFineEmails = emailsWithFine.Where(x => x.FinePaid > 500).ToList();
                    overdueFineEmails.ForEach(x =>
                    {
                        var overdueFineEmailsBody = $"Merhaba {x.User?.FirstName} {x.User?.LastName}.{x.FinePaid} lira {x.Book?.Title} " +
                        $"kitabından dolayı borcunuzdan dolayı hesabını kapanmıstır ";


                        _emailService.SendEmail(x.User?.Email!, "Fine Overdue", overdueFineEmailsBody);
                    });

                    return Ok("sent");
                }
                return Unauthorized();
            }
            return NotFound();

        }
        [HttpGet("BlockFineOverdueUsers")]
        public ActionResult BlockFineOverdueUsers(string employeeId)
        {
            var employee = _context.Users.Find(employeeId);
            if (employee is not null)
            {
                if (employee.UserType == UserType.EMPLOYEE)
                {
                    var orders = _context.Orders
                            .Include(o => o.Book)
                            .Include(o => o.User)
                            .Where(o => !o.Returned)
                            .ToList();

                    var emailsWithFine = orders.Where(o => DateTime.Now > o.OrderDate.AddDays(10)).ToList();
                    emailsWithFine.ForEach(x => x.FinePaid = (DateTime.Now - x.OrderDate.AddDays(10)).Days * 50);

                    var users = emailsWithFine.Where(x => x.FinePaid > 500).Select(x => x.User!).Distinct().ToList();

                    if (users is not null && users.Any())
                    {
                        foreach (var user in users)
                        {
                            user.AccountStatus = AccountStatus.BLOCKED;
                        }
                        _context.SaveChanges();

                        return Ok("blocked");
                    }
                    else
                    {
                        return Ok("not blocked");
                    }
                }
                return Unauthorized();
            }
            return NotFound();


        }
        [HttpGet("Unblock")]
        public ActionResult Unblock(string userId, string employeeId)
        {
            var employee = _context.Users.Find(employeeId);
            if (employee is not null)
            {
                if (employee.UserType == UserType.MEMBER)
                {
                    var user = _context.Users.Find(userId);
                    if (user is not null)
                    {

                        user.AccountStatus = AccountStatus.ACTIVE;
                        _context.SaveChanges();
                        return Ok("unblocked");
                    }

                    return Ok("not unblocked");
                }
                return Unauthorized();
            }
            return NotFound();

        }












    }
}
