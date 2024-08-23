using System.ComponentModel.DataAnnotations;

namespace Library_Apı_Sysytem.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; }
        public int? BookId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Returned { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int FinePaid { get; set; }

        public User? User { get; set; }
        public Book? Book { get; set; }
    }
}
