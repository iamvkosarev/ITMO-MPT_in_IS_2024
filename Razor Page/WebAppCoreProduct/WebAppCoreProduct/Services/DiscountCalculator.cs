using System.Runtime.CompilerServices;
using WebAppCoreProduct.Interfaces;

namespace WebAppCoreProduct.Services
{
    public class DiscountCalculator : IDiscountCalculator
    {
        public decimal GetDiscount(string name, decimal price, out string message)
        {
            var result = price * (decimal)0.18;
            message = $"Для товара {name} с ценой {price} скидка получится {result}";
            return result;
        }

        public decimal GetDiscount(string name, decimal price, double discount, out string message)
        {
            var result = price * (decimal)discount / 100;
            message = $"Для товара {name} с ценой {price} и скидкой {discount} получится {result}";
            return result;
        }
    }
}
