using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationChart
{
    public class Data
    {
        public Data(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; set; }
        public int Value { get; set; }
    }
    class Model
    {
        public IList<Data> Data
        {
            get
            {
                IList<Data> list = new List<Data>
                {
                    new Data("Иванов", 10), 
                    new Data("Петров", 30), 
                    new Data("Сиборов", 10),
                    new Data("Кузнецов", 20),
                    new Data("Павлов", 40)
                };
                return list;
            }
        }
    }

}
