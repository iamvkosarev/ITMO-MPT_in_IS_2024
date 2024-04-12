using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using WebAppCoreProduct.Interfaces;
using WebAppCoreProduct.Models;
using WebAppCoreProduct.Services;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        private readonly IDiscountCalculator _discountCalculator;
        private readonly IProductDataChecker _productDataChecker;
        public Product Product { get; set; }

        public string? MessageRezult { get; private set; }

        public ProductModel(IDiscountCalculator discountCalculator, IProductDataChecker productDataChecker)
        {
            _discountCalculator = discountCalculator;
            _productDataChecker = productDataChecker;
        }

        public void OnGet()
        {
            MessageRezult = "��� ������ ����� ���������� ������";
        }

        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (!_productDataChecker.IsCorrect(name, price, out string checkDataMessage))
            {
                MessageRezult = checkDataMessage;
                return;
            }
            _discountCalculator.GetDiscount(name, price.Value, out string discountMessage);
            MessageRezult = discountMessage;
            Product.Price = price;
            Product.Name = name;
        }
        public void OnPostCheckPrice(string name, decimal? price)
        {
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
                return;
            }

            if (price <= 50)
            {

                MessageRezult = $"����� {name} � ����� {price} ����� �������";
            }
            else if (price <= 100)
            {

                MessageRezult = $"����� {name} � ����� {price} �������";
            }
            else
            {
                var tPrice = (int)price / 100;
                StringBuilder stringBuilder = new StringBuilder();
                while (tPrice / 10 > 0)
                {
                    tPrice /= 10;
                    stringBuilder.Append("����� ");
                }
                MessageRezult = $"����� {name} � ����� {price} {stringBuilder.ToString()}�������";
            }
        }
        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();
            if (!_productDataChecker.IsCorrect(name, price, out string checkDataMessage))
            {
                MessageRezult = checkDataMessage;
                return;
            }
            _discountCalculator.GetDiscount(name, price.Value, discont,  out string discountMessage);
            MessageRezult = discountMessage;
            Product.Price = price;
            Product.Name = name;
        }
    }
}
