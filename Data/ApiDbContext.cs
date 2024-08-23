using Library_Apı_Sysytem.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Library_Apı_Sysytem.Data
{
    public class ApiDbContext : IdentityDbContext<User>
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new User
            {
                FirstName = "Admin",
                LastName = "Adminlastname",
                Email = "admin@gmail.com",
                PhoneNumber = "1234567890",
                AccountStatus = AccountStatus.ACTIVE,
                UserType = UserType.EMPLOYEE,
                Password = "admin1992",
                CreatedOn = new DateTime(2024, 8, 03, 13, 28, 12)
            });
            builder.Entity<User>().HasData(new User
            {
                FirstName = "Member",
                LastName = "MemberLastName",
                Email = "member@gmail.com",
                PhoneNumber = "9876543210",
                AccountStatus = AccountStatus.ACTIVE,
                UserType = UserType.MEMBER,
                Password = "member1999",
                CreatedOn = DateTime.Now,
            });
            builder.Entity<BookCategory>().HasData(
                new BookCategory { Id = 1, Category = "Roman", SubCategory = "Dram" },
                new BookCategory { Id = 2, Category = "Roman", SubCategory = "Bilim Kurgu" },
                new BookCategory { Id = 3, Category = "Roman", SubCategory = "Biyografi" },
                new BookCategory { Id = 4, Category = "Akademik", SubCategory = "Matematik" },
                new BookCategory { Id = 5, Category = "Akademik", SubCategory = "Bilgisayar Bilimleri" },
                new BookCategory { Id = 6, Category = "Dergi", SubCategory = "Kimya" },
                new BookCategory { Id = 7, Category = "Dergi", SubCategory = "Fizik" },
                new BookCategory { Id = 8, Category = "Dil", SubCategory = "Ingilizce" }
                );

            builder.Entity<Book>().HasData(
           new Book { Id = 1, BookCategoryId = 1, Ordered = false, Author = "Yasar Kemal", Title = "Yer Demir Gök Bakır" },
           new Book { Id = 2, BookCategoryId = 1, Ordered = false, Author = "Yasar Kemal", Title = "Ortadirek" },
           new Book { Id = 3, BookCategoryId = 1, Ordered = false, Author = "Yasar Kemal", Title = "Kuşlar da Gitti" },
           new Book { Id = 4, BookCategoryId = 1, Ordered = false, Author = "Yasar Kemal", Title = "Karıncanın Su İçtiği" },
           new Book { Id = 5, BookCategoryId = 1, Ordered = false, Author = "Orhan Pamuk", Title = "Masumiyet Müzesi" },
           new Book { Id = 6, BookCategoryId = 1, Ordered = false, Author = "Orhan Pamuk", Title = "Benim Adım Kırmızı" },
           new Book { Id = 7, BookCategoryId = 1, Ordered = false, Author = "Orhan Pamuk", Title = "Veba Geceleri" },
           new Book { Id = 8, BookCategoryId = 1, Ordered = false, Author = "Orhan Pamuk", Title = "Cevdet Bey ve Oğulları" },
           new Book { Id = 9, BookCategoryId = 1, Ordered = false, Author = "Orhan Pamuk", Title = "Kafamda Bir Tuhaflık" },

           new Book { Id = 10, BookCategoryId = 2, Ordered = false, Author = "Stephen King", Title = "Medyum" },
           new Book { Id = 11, BookCategoryId = 2, Ordered = false, Author = "Stephen King", Title = "Sadist" },
           new Book { Id = 12, BookCategoryId = 2, Ordered = false, Author = "Stephen King", Title = "Yeşil Yol" },
           new Book { Id = 13, BookCategoryId = 2, Ordered = false, Author = "Paul Barry", Title = "" },
           new Book { Id = 14, BookCategoryId = 2, Ordered = false, Author = "Joshua Bloch", Title = "Java" },
           new Book { Id = 15, BookCategoryId = 2, Ordered = false, Author = "Joshua Bloch", Title = "JavaScript" },
           new Book { Id = 16, BookCategoryId = 2, Ordered = false, Author = "Kathy Sierra and Bert Bates", Title = "Head First Java" },
           new Book { Id = 17, BookCategoryId = 2, Ordered = false, Author = "Ursula K. Le Guin", Title = "Yerdeniz Büyücüsü" },
           new Book { Id = 18, BookCategoryId = 2, Ordered = false, Author = "Ursula K. Le Guin", Title = "Karanlığın Sol Eli" },
           new Book { Id = 19, BookCategoryId = 2, Ordered = false, Author = "Ursula K. Le Guin", Title = "Dünyaya Orman Denir" },
           new Book { Id = 20, BookCategoryId = 2, Ordered = false, Author = "Marijn Haverbeke", Title = "Python" },
           new Book { Id = 21, BookCategoryId = 2, Ordered = false, Author = "Donald E. Knuth", Title = "Design Pattern" },
           new Book { Id = 22, BookCategoryId = 2, Ordered = false, Author = "Donald E. Knuth", Title = "Redis" },

           new Book { Id = 23, BookCategoryId = 3, Ordered = false, Author = "James F Kurose and Keith W Ross", Title = "A Top-Down Approach: Computer Networking" },
           new Book { Id = 24, BookCategoryId = 3, Ordered = false, Author = "Rich Seifert and James Edwards", Title = "The All-New Switch Book (2nd Edition)" },
           new Book { Id = 25, BookCategoryId = 3, Ordered = false, Author = "Rich Seifert and James Edwards", Title = "The All-New Switch Book (2nd Edition)" },
           new Book { Id = 26, BookCategoryId = 3, Ordered = false, Author = "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova", Title = "Business Data Communications and Networking (14th Edition)" },
           new Book { Id = 27, BookCategoryId = 3, Ordered = false, Author = "Forouzan", Title = "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition" },
           new Book { Id = 28, BookCategoryId = 3, Ordered = false, Author = "Gary Donahue", Title = "Network Warrior, 2nd Edition" },
           new Book { Id = 29, BookCategoryId = 3, Ordered = false, Author = "Gary Donahue", Title = "Network Warrior, 2nd Edition" },
           new Book { Id = 30, BookCategoryId = 3, Ordered = false, Author = "Gary Donahue", Title = "Network Warrior, 2nd Edition" },

           new Book { Id = 31, BookCategoryId = 4, Ordered = false, Author = "Ramesh Gaonkar", Title = "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)" },
           new Book { Id = 32, BookCategoryId = 4, Ordered = false, Author = "Douglas V. Hall", Title = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
           new Book { Id = 33, BookCategoryId = 4, Ordered = false, Author = "Douglas V. Hall", Title = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
           new Book { Id = 34, BookCategoryId = 4, Ordered = false, Author = "Kenneth L. Short", Title = "Embedded Microprocessor Systems Design" },
           new Book { Id = 35, BookCategoryId = 4, Ordered = false, Author = "Dr. Vibhav Kumar Sachan", Title = "Digital Electronics & Microprocessor" },
           new Book { Id = 36, BookCategoryId = 4, Ordered = false, Author = "Xiaocong Fan", Title = "Real-Time Embedded Systems" },
           new Book { Id = 37, BookCategoryId = 4, Ordered = false, Author = "Jonathan A. Dell", Title = "Digital Interface Design and Application" },

           new Book { Id = 38, BookCategoryId = 5, Ordered = false, Author = "Shigley's Mechanical Engineering Design", Title = "Richard G. Budynas and Keith J. Nisbett" },
           new Book { Id = 39, BookCategoryId = 5, Ordered = false, Author = "Shigley's Mechanical Engineering Design", Title = "Richard G. Budynas and Keith J. Nisbett" },
           new Book { Id = 40, BookCategoryId = 5, Ordered = false, Author = "Shigley's Mechanical Engineering Design", Title = "Richard G. Budynas and Keith J. Nisbett" },
           new Book { Id = 41, BookCategoryId = 5, Ordered = false, Author = "Erik Oberg", Title = "Machinery's Handbook" },
           new Book { Id = 42, BookCategoryId = 5, Ordered = false, Author = "John J. Craig", Title = "Introduction to Robotics: Mechanics and Control" },
           new Book { Id = 43, BookCategoryId = 5, Ordered = false, Author = "Robert L. Norton", Title = "Machine Design" },
           new Book { Id = 44, BookCategoryId = 5, Ordered = false, Author = "Robert L. Norton", Title = "Machine Design" },

           new Book { Id = 45, BookCategoryId = 6, Ordered = false, Author = "Frank M. White", Title = "Fluid Mechanics" },
           new Book { Id = 46, BookCategoryId = 6, Ordered = false, Author = "Claus Borgnakke and Richard E. Sonntag", Title = "Fundamentals of Thermodynamics" },
           new Book { Id = 47, BookCategoryId = 6, Ordered = false, Author = "Claus Borgnakke and Richard E. Sonntag", Title = "Fundamentals of Thermodynamics" },

           new Book { Id = 48, BookCategoryId = 7, Ordered = false, Author = "James Stewart", Title = "Calculus: Early Transcendentals" },
           new Book { Id = 49, BookCategoryId = 7, Ordered = false, Author = "Mark Ryan", Title = "Calculus for Dummies" },
           new Book { Id = 50, BookCategoryId = 7, Ordered = false, Author = "Mark Ryan", Title = "Calculus for Dummies" },
           new Book { Id = 51, BookCategoryId = 7, Ordered = false, Author = "Louis Leithold", Title = "The Calculus with Analytic Geometry" },

           new Book { Id = 52, BookCategoryId = 8, Ordered = false, Author = "Euclid", Title = "Euclid's Elements" },
           new Book { Id = 53, BookCategoryId = 8, Ordered = false, Author = "Robert Kanigel", Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
           new Book { Id = 54, BookCategoryId = 8, Ordered = false, Author = "Robert Kanigel", Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
           new Book { Id = 55, BookCategoryId = 8, Ordered = false, Author = "Stephen Hawking", Title = "A Brief History of Time" },
           new Book { Id = 56, BookCategoryId = 8, Ordered = false, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 57, BookCategoryId = 8, Ordered = false, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 58, BookCategoryId = 8, Ordered = false, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 59, BookCategoryId = 8, Ordered = false, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 60, BookCategoryId = 8, Ordered = false, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" });


            builder.Entity<IdentityUserLogin<string>>().HasNoKey();
            builder.Entity<IdentityUserRole<string>>().HasNoKey();
            builder.Entity<IdentityUserToken<string>>().HasNoKey();
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<UserType>().HaveConversion<string>();//Enum turleri veri tababında  gösterebilmek  icin yazılır
            configurationBuilder.Properties<AccountStatus>().HaveConversion<string>();
        }
    }
}
