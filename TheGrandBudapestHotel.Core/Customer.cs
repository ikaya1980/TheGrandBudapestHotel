using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TheGrandBudapestHotel.Core
{
  

    public class Customer 
    {
        const string personNameFormat = "^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";

        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Nationality Nationality { get; set; }

        public bool Validate()
        {
            //TODO Gerekli kontrolleri yapacak. 
            if (string.IsNullOrWhiteSpace(this.FirstName))
                return false;

            Regex regex = new Regex(personNameFormat);
            return regex.Match(this.FirstName).Success;
            
        }
    }


}
