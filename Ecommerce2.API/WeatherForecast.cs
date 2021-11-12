namespace Ecommerce2.API
{
    public class UserInformation
    {
        public string UserName { get; set; }

        public int Password { get; set; }

        public DateTime DOB { get; set; };

        public string? Description { get; set; }

        public float Price { get; set; }

        public string Title { get; set; }
    }
}