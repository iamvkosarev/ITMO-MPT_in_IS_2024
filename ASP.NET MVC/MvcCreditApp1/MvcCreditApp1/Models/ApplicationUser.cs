using Microsoft.AspNetCore.Identity;

namespace MvcCreditApp1.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Добавьте сюда свои дополнительные поля
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
