using System.ComponentModel;

namespace WebMVCR1.Models
{
    public class Person
    {
        [DisplayName("Имя")]
        public string FirstName { get; set; }
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        public override string ToString() => FirstName + " " +
       LastName;
    }
}
