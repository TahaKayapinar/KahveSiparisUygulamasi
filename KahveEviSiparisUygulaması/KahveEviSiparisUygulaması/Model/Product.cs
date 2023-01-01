using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveEviSiparisUygulaması.Model
{
    public class Product
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}
