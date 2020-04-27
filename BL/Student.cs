using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Student:Client
    {
        private string formLearn;
        //private string nameUniversity;
        //private int studentID;

        public Student(string dateOfBirth, string formLearn):base(dateOfBirth) { this.formLearn = formLearn; }

        public override int priceCalculation()
        {
            int price = 0;
            int priceSt=0;
            string s1 = "Очная";
            string s2 = "Заочная";
            if (dateOfBirth.Contains(curDate))
            {
                price = fixedPrice - (fixedPrice * 10 / 100);
            }

            if (formLearn.StartsWith(s1))
            {
                priceSt = fixedPrice - (fixedPrice * 15 / 100);
            }
            else if(formLearn.StartsWith(s2))
            {
                return fixedPrice;
            }
           
            if (dateOfBirth.Contains(curDate) & formLearn.StartsWith(s1))
            {
                priceSt = price - (price * 15 / 100);
            }

            if (dateOfBirth.Contains(curDate) & formLearn.StartsWith(s2))
            {
                return price;
            }
            return priceSt;
        }
    }
}
