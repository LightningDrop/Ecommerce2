using Ecommerce2.Util;

namespace Ecommcerce2.Core.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Automatically calculate Age 
        public int Age => DateUtilities.GetIntYears(DateTime.Today.Subtract(DateOfBirth));

    }
}
