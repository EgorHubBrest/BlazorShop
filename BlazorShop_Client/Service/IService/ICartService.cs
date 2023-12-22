using BlazorShop_Client.ViewModels;

namespace BlazorShop_Client.Service.IService
{
    public interface ICartService
    {
        public event Action OnChanged;
        Task DecrementCart(ShoppingCart shoppingCart);
        Task IncrementCart(ShoppingCart shoppingCart);
    }
}
