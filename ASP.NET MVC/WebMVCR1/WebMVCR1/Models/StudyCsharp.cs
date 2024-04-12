using System.Security.AccessControl;
using System.Text;

namespace WebMVCR1.Models
{
    public enum AccountType
    {
        Checking,
        Deposit
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
        public override string ToString() => $"Номер счета {accNo}, баланс {accBal}, тип{accType}";
    }

    public class StudyCsharp
    {
        public static string SetStatus(int age)
        {
            string status = "junior developer";
            if ((age > 2) && (age < 7)) status = "middle developer";
            else if ((age >= 7) && (age < 15)) status = "senior developer";
            else if ((age >= 15)) status = "wizard";
            return status;
        }

        public static string ExeSwitch(string status)
        {
            string res;
            switch (status)
            {
                case "junior developer":
                    res = "Набирайся знаний"; break;
                case "middle developer":
                    res = "Набирайся опыта"; break;
                case "senior developer":
                    res = "Руководи другими"; break;
                case "sensei":
                    res = "Учи других"; break;
                default:
                    res = "Не знаю, что делать";
                    break;
            }
            return res;
        }
        public static string GetFunction(double x1, double x2)
        {
            StringBuilder str = new StringBuilder();
            double x = x1;
            do
            {
                str.AppendFormat("x = {0:0.##} : y = {1:0.##}; \n", x,
               Math.Pow(x, 3));
                x = x + 0.5;
            }
            while (x <= x2);
            return str.ToString(); ;
        }
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;
            try
            {
                checked
                {
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;

        }

    }

    public class Triangle : Shape, IComparable<Triangle>
    {
        public double Stb { get; set; }
        public double Stc { get; set; }

        public override string Name => String.Format("\"Треугольник со сторонами {0}, {1} и {2}\"", St, Stb, Stc);
        public double Perimeter => St + Stb + Stc;
        public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - St) *
                (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
        public Triangle(double a, double b, double c)
        {
            St = a;
            Stb = b;
            Stc = c;
        }

        public int CompareTo(Triangle? other)
        {
            if (this.Area == other.Area) return 0;
            else if (this.Area > other.Area) return 1;
            else return -1;
        }
    }

    public class Circle : Shape, IComparable<Circle>
    {
        public override string Name
        {
            get
            {
                return String.Format("\"Окружность с радиусом {0}\"", St);
            }
        }
        public Circle(double a)
        {
            St = a;
        }
        public double Dlina
        {
            get
            {
                double p = 2 * Math.PI * St;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.PI * St * St;
                return sq;
            }
        }

        public int CompareTo(Circle? other)
        {
            if (this.Area == other.Area) return 0;
            else if (this.Area > other.Area) return 1;
            else return -1;
        }
    }

    public class Shape
    {
        public double St { get; set; }
        virtual public string Name
        {
            get { return String.Format("\"Фигура\""); }
        }

    }
}
