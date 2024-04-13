
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp1.Models
{
    public class Credit
    {// ID кредита
        public virtual int CreditId { get; set; }
        // Название

        [DisplayName("Название кредита")]
        [Required]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит

        [DisplayName("Период")]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        [DisplayName("Максимальная сумма кредита")]
        public virtual int Sum { get; set; }
        // Процентная ставка

        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }
    }
}
