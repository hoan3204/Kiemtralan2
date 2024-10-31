using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikiemtralan2
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; private set; } = new List<ShoppingCartItem>();

        public void AddToCart(Product product, int quantity)
        {
            var item = Items.FirstOrDefault(i => i.Product.Name == product.Name);
            if (item == null)
            {
                Items.Add(new ShoppingCartItem(product, quantity));
            }
            else
            {
                item.Quantity += quantity;
            }
        }

        public void RemoveFromCart(string productName)
        {
            var item = Items.FirstOrDefault(i => i.Product.Name == productName);
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public decimal CalculateTotalPrice()
        {
            return Items.Sum(i => i.TotalPrice);
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }

}
