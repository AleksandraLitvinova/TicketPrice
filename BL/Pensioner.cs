using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pensioner:Client
    {
        private string warVeteran;
        //private int pensionerID;

        public Pensioner(string dateOfBirth, string warVeteran):base(dateOfBirth) { this.warVeteran = warVeteran; }

        public override int priceCalculation()
        {
            int price = 0;
            int pricePn = 0;
            string s1 = "Да";
            string s2 = "Нет";
            if (dateOfBirth.Contains(curDate))
            {
                price = fixedPrice - (fixedPrice * 10 / 100);
            }

            if (warVeteran.StartsWith(s1))
            {
                pricePn = fixedPrice - (fixedPrice * 20 / 100);
            }
            else if (warVeteran.StartsWith(s2))
            {
                return fixedPrice;
            }

            if (dateOfBirth.Contains(curDate) & warVeteran.StartsWith(s1))
            {
                pricePn = price - (price * 20 / 100);
            }

            if (dateOfBirth.Contains(curDate) & warVeteran.StartsWith(s2))
            {
                return price;
            }
            return pricePn;

        }
    }
}
