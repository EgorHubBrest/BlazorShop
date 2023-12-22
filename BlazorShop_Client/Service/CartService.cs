using Blazored.LocalStorage;
using BlazorShop_Client.Service.IService;
using BlazorShop_Client.ViewModels;
using BlazoShop_Common;

namespace BlazorShop_Client.Service
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
		public event Action OnChanged;


        public CartService(ILocalStorageService localStorageService)
        {
			_localStorage = localStorageService;
		}

        public async Task IncrementCart(ShoppingCart cartToAdd)
        {
			var cart = await _localStorage.GetItemAsync<List<ShoppingCart>>(SD.ShoppingCart);
			bool itemInCart = false;

			if (cart == null)
			{
				cart = new List<ShoppingCart>();
			}
			foreach (var obj in cart)
			{
				if (obj.ProductId == cartToAdd.ProductId && obj.ProductPriceId == cartToAdd.ProductPriceId)
				{
					itemInCart = true;
					obj.Count += cartToAdd.Count;
				}
			}
			if (!itemInCart)
			{
				cart.Add(new ShoppingCart()
				{
					ProductId = cartToAdd.ProductId,
					ProductPriceId = cartToAdd.ProductPriceId,
					Count = cartToAdd.Count
				});
			}
			await _localStorage.SetItemAsync(SD.ShoppingCart, cart);
            OnChanged.Invoke();

        }
        public async Task DecrementCart(ShoppingCart shoppingCart)
        {
            var cart = await _localStorage.GetItemAsync<List<ShoppingCart>>(SD.ShoppingCart);
            //if count is 0 or 1 then we remove the item
            for(int i=0; i<cart.Count; i++)
            {
                if (cart[i].ProductId == shoppingCart.ProductId && cart[i].ProductPriceId == shoppingCart.ProductPriceId)
                {
                    if(cart[i].Count == 1 || shoppingCart.Count == 0)
                    {
                        cart.Remove(cart[i]);
                    }
                    else
                    {
                        cart[i].Count -= shoppingCart.Count;
                    }
                }
            }

            await _localStorage.SetItemAsync(SD.ShoppingCart, cart);
            OnChanged.Invoke();
        }
    }
}
