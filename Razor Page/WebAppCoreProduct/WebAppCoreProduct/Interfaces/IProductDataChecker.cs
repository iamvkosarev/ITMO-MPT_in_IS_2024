namespace WebAppCoreProduct.Interfaces
{
    public interface IProductDataChecker
    {
        bool IsCorrect(string name, decimal? price, out string message);
    }
}
