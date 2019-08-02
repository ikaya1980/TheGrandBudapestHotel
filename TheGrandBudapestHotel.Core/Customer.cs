using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TheGrandBudapestHotel.Core
{
  

    public class Customer 
    {
        
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Nationality Nationality { get; set; }

        public bool Validate()
        {
            //TODO Gerekli kontrolleri yapacak. 
           throw new NotImplementedException();
            
        }
    }


}
