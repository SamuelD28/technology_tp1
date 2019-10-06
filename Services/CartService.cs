using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using technology_tp1.Models;

namespace technology_tp1.Services
{
    public class CartService : ICartService
    {
        private const string CartKey = "cart";
        // minutes
        private const int DefaultExpirationTime = 44_640;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private Dictionary<int, int> _cartItems = new Dictionary<int, int>();

        /// <summary>
        /// Get the number of items in the cart
        /// </summary>
        public int CartCount => _cartItems.Count;

        public CartService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            QueryCookies();
        }

        public void AddItem(int itemId, int quantity = 1)
        {
            _cartItems[itemId] = quantity;
        }

        public void Save()
        {
            StringBuilder builder = new StringBuilder();
            int count = 1;
            foreach (var item in _cartItems)
            {
                builder.Append(item.Key).Append(":").Append(item.Value);
                if (count++ < CartCount)
                    builder.Append(",");
            }
            Set(CartKey, builder.ToString(), DefaultExpirationTime);
        }

        private void QueryCookies()
        {
            string rawCart = Get(CartKey) ?? String.Empty;
            Regex regex = new Regex("-?[0-9]+:[0-9]+");
            foreach (Match match in regex.Matches(rawCart))
            {
                string[] values = match.Value.Split(":");
                AddItem(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]));
            }
        }

        private string Get(string key)
        {
            return _httpContextAccessor.HttpContext.Request.Cookies[key];
        }

        private void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);
            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, option);
        }

        private void Remove(string key)
        {
            _httpContextAccessor.HttpContext.Response.Cookies.Delete(key);
        }
    }

    static class CartServiceExt
    {
        public static void AddCartService(this IServiceCollection services)
        {
            services.AddTransient<ICartService, CartService>();
        }
    }
}
