using Ecommerce2.Util;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce2.Web.Models.DTOs
{
    public class AccountDTO
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        // Automatically calculate Age 
        public int Age => DateUtilities.GetIntYears(DateTime.Today.Subtract(DateOfBirth));


        // May need to get rid of this in the future 
        public AccountDTO(int Id, string UserName, string FirstName, string LastName, string Email, DateTime DateOfBirth)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
        }

    }
}
