using System;
using TheGrandBudapestHotel.Core;
using System.Collections.Generic;

namespace TheGrandBudapestHotel.Data
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetCustomers();
        
        Customer GetById(int id);
        Customer Update(Customer updatedRestaurant);
        Customer Add(Customer newRestaurant);
        Customer Delete(int id);
        //int GetCountOfRestaurants();
        int Commit();
    }

  
}
