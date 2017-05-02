using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public int PageCount { get; set; }
        public string ISBN { get; set; }
    }
}
