using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Vacancies.AdminPanel.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Email is required!")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please, indicate correct email!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Phone number is required!")]
        [StringLength(50)]
        [DataType(DataType.PhoneNumber,ErrorMessage = "Please, indicate correct phone number!")] //format
        public string PhoneNumber { get; set; }

       // public Roles Roles { get; set; }
    }
}
