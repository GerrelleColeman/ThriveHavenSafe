using Microsoft.EntityFrameworkCore;

namespace ThriveHavenSafe.Models.CartStuff
{
    public interface ICartRepository
    {

        IEnumerable<Cart> Cart { get; }

        IEnumerable<Cart> GetCartByUser(Guid userId);

        
        Cart? GetCartByUserId(Guid userId);

        Cart Add(Cart cart);

        void Update(Cart cart);
        void Delete(Cart cart);

    }
}
