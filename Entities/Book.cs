using System.ComponentModel.DataAnnotations;

namespace Library_Apı_Sysytem.Entities
{
    public class Book
    {
        [Key]
        public int? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
       
        public bool Ordered { get; set; }
        public int? BookCategoryId { get; set; }

        public BookCategory? BookCategory { get; set; }
    }
}
