using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySaver.Model
{

    public class Transaction
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public string Person { get; set; }
        public decimal Value { get; set; }

    }
}
