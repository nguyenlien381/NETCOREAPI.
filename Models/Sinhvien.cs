using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    [Table("Sinhvien")]
    public class Sinhvien
    {
        [Key]
        public int Id { get; set;}
        public string Name { get; set; }
        public string Address { get; set; }
    }
}