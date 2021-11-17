using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopProject.Data
{
    public class CartManager
    {
        public static List<Models.Product> Cart { get; set; } = new List<Models.Product>();

        public static List<Models.Product> GetCart()
        {
            return Cart;
        }

        public static List<Models.Product> AddCart(Models.Product cartProduct)
        {
            
            Cart.Add(cartProduct); // Exempel på att lägga till i kundkorgen
            return Cart;
        }
    }
}
