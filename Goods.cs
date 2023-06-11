using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovars_wpf
{
  
    public class Goods
    {       
        public string? Name { get; set; }
        public int Amount { get; set; }
        public Measure Measure { get; set; }

        public Goods Copy() => new Goods() { Name = Name, Amount = Amount, Measure = Measure };
    }
}
