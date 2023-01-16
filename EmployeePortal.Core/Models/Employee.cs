using System.ComponentModel.DataAnnotations;

namespace CRUDOPERATION.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public decimal Salary { get; set; }

    }
}
