using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HieuLinhMidTest.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int ID { get; set; }
        
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsYoungDriver { get; set; }
    }
}