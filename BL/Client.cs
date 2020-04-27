using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class Client
    {
        public string dateOfBirth;
        //private int id;
        //private string name;
        //private string surname;
        //private string middleName;
        //private string gender;
        //private int email;
        public int fixedPrice=400;
        public string curDate = DateTime.Now.ToString("dd.MM");

        public Client(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
       
        public virtual int priceCalculation()
        {
            int price=0;
           
            if (dateOfBirth.Contains(curDate))
            {
                price = fixedPrice - (fixedPrice * 10 / 100);
            }
            else { return fixedPrice; }
            return price;
        }
    }
}
