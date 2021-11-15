using Ecommcerce2.Core.Interfaces;
using Ecommcerce2.Core.Models.FEModels;

namespace Ecommcerce2.Core.Services
{
    public class InMemoryCartData : ICartData
    {
        // This can be removed later ... 
        private int genID = 0;

        readonly List<Cart> _carts = new List<Cart>();

        public InMemoryCartData()
        {

        }

        // START PUBLIC METHODS 
        public Task<IEnumerable<Cart>> GetAll()
        {
            IEnumerable<Cart> _carts = new List<Cart>();
            var carts = _carts;
            return Task.FromResult(carts);
        }

        public Task<Cart> Get(int id)
        {
            var cartById =
                from cart in _carts
                where cart.Id == id
                select cart;

            // cartById returns IEnumerable meaning we have to cast it as a single cart 
            return Task.FromResult<Cart>((Cart)cartById);

        }

    }
}
