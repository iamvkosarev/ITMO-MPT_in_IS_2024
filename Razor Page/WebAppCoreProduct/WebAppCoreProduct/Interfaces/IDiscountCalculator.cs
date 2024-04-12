namespace WebAppCoreProduct.Interfaces
{
    public interface IDiscountCalculator
    {
        decimal GetDiscount(string name, decimal price, out string message);
        decimal GetDiscount(string name, decimal price, double discount, out string message);
    }
}
