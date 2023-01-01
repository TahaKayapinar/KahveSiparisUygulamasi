using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveEviSiparisUygulaması.Model
{
    public class Order
    {
        //Adı Soyadı

        public string NameSurname { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }



        //Sipariş Kahvesi
        public Product Coffee { get; set; }

        //Sipariş Kahve Adedi
        public int CoffeCount { get; set; }


        //Soğuk İçecek
        public Product ColdDrink { get; set; }
        //Soğuk İçecek adedi
        public int ColdDrinkCount { get; set; }

        //Sıcak İçecek
        public Product HotDrink { get; set; }
        //Sıcak İçecek Adet
        public int HotDrinkCount { get; set; }


        //Çarpan   1 1X   -   2 2X
        public short Shot { get; set; }
        public decimal ShotPrice
        {
            get
            {
                return 0.75m;
            }

        }

        public string ShotName
        {
            get
            {
                return this.Shot.ToString() + "X";
            }
        }



        //Süt   1 Yağsız  -  2 Soya
        public short Milk { get; set; }
        public decimal MilkPrice
        {
            get
            {
                return 0.5m;
            }
        }

        public string MilkName
        {
            get
            {
                string milkName = "Yağsız";
                if (this.Milk == 2)
                {
                    milkName = "Soya";
                }
                return milkName;
            }
        }


        // Boyut     1   Tall    2  Grande    3 Venti
        public short Size { get; set; }
        public decimal SizePrice
        {
            get
            {
                decimal sizePriceValue = 1;
                if (this.Size == 2)
                {
                    sizePriceValue = 1.25m;
                }
                else if (this.Size == 3)
                {
                    sizePriceValue = 1.75m;
                }
                return sizePriceValue;
            }
        }

        public string SizeName
        {
            get
            {
                string sizeName = "Tall";
                if (this.Size == 2)
                {
                    sizeName = "Grande";
                }
                else if (this.Size == 3)
                    sizeName = "Venti";
                return sizeName;

            }
        }

        public decimal Total
        {
            get
            {
                decimal totalValue = 0;
                if (this.Coffee != null)
                    totalValue += (this.Coffee.Fiyat * this.CoffeCount);
                if (this.ColdDrink != null)
                    totalValue += (this.ColdDrink.Fiyat * this.ColdDrinkCount);
                if (this.HotDrink != null)
                    totalValue += (this.HotDrink.Fiyat * this.HotDrinkCount);

                totalValue += this.ShotPrice;
                totalValue += this.MilkPrice;
                totalValue += this.SizePrice;

                

                return totalValue;
            }
        }

        public override string ToString()
        {
            StringBuilder productString = new StringBuilder();
            productString.Append(this.SizeName);

            if (this.Coffee != null)
                productString.AppendFormat(", {0} ", this.Coffee.Adi);

            if (this.ColdDrink != null)
                productString.AppendFormat(", {0} ", this.ColdDrink.Adi);

            if(this.HotDrink != null)
                productString.AppendFormat(", {0} ", this.HotDrink.Adi);


            productString.AppendFormat("Süt => {0}", this.MilkName);
            productString.AppendFormat("Shot => {0}", this.ShotName);
            productString.AppendFormat(": {0}", this.Total);

            return productString.ToString();

        }
    }
}
