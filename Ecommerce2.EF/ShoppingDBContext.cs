using Ecommcerce2.BE;
using System.Data.Entity;


namespace Ecommerce2.EF
{
    public class ShoppingDBContext : DbContext
    {
        public DbSet<ShoppingList>? ShoppingList { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        // options.UseSqlServer("" +
        //   "Data Source=(localdb)\\MSSQLLocalDB;" +
        //   "Initial Catalog=ReBidlyAppData;" +
        //  "Integrated Security=True;" +
        //   "Connect Timeout=30;" +
        //   "Encrypt=False;" +
        //   "TrustServerCertificate=False;" +
        //   "ApplicationIntent=ReadWrite;" +
        //   "MultiSubnetFailover=False");
        //}   
    }


}
