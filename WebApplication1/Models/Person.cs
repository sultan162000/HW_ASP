using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имю")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Введите фамилию")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        
    }
}

