using System.ComponentModel.DataAnnotations;

namespace Library_Apı_Sysytem.Entities
{
    public class BookCategory
    {
        [Key]
        public int? Id { get; set; }
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
    }
}
