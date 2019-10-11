using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Services
{
    static class CartServiceExt
    {
        public static void AddCartServiceCookie(this IServiceCollection services)
        {
            services.AddTransient<ICartService, CartService>();
        }

        public static JToken ToJson(this ICartService cart)
        {
            decimal price = 0;
            JObject result = new JObject();
            JArray jArray = new JArray();
            foreach (var item in cart.Items)
            {
                JObject itemJson = new JObject();
                itemJson.Add("id", new JValue(item.MenuItem.Id));
                itemJson.Add("image", new JValue(item.MenuItem.Image.Small));
                itemJson.Add("imageId", new JValue(item.MenuItem.ImageId));
                itemJson.Add("name", new JValue(item.MenuItem.Name));
                itemJson.Add("price", new JValue(item.MenuItem.Price));

                JObject cartItem = new JObject();
                cartItem.Add("item", itemJson);
                cartItem.Add("quantity", item.Quantity);
                price += item.Quantity * item.MenuItem.Price;
                jArray.Add(cartItem);
            }

            result.Add("items", jArray);
            result.Add("distinctItemsCount", new JValue(cart.CartCountDistinctItem));
            result.Add("itemCount", new JValue(cart.CartCount));
            result.Add("totalPrice", new JValue(price));

            return result;
        }
    }
}
