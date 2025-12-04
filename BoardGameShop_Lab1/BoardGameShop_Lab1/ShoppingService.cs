using System.Collections.Generic;
using System.Linq;

namespace BoardGameShop_Lab1
{
    
    public static class ShoppingService
    {
       
        public static List<CartItem> CartItems = new List<CartItem>();

        
        public static void AddToCart(int id, string title, decimal price)
        {
            
            var existingItem = CartItems.FirstOrDefault(x => x.GameId == id);

            if (existingItem != null)
            {
               
                existingItem.Quantity++;
            }
            else
            {
              
                CartItems.Add(new CartItem
                {
                    GameId = id,
                    Title = title,
                    Price = price,
                    Quantity = 1
                });
            }
        }

        public static void ClearCart()
        {
            CartItems.Clear();
        }
    }
}