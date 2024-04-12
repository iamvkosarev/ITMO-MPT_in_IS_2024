using WebAppCoreProduct.Interfaces;

namespace WebAppCoreProduct.Services
{
    public class ProductDataChecker : IProductDataChecker
    {
        public bool IsCorrect(string name, decimal? price, out string message)
        {
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                message = "Переданы некорректные данные. Повторите ввод";
                return false;
            }
            message = string.Empty;
            return true;
        }
    }
}
