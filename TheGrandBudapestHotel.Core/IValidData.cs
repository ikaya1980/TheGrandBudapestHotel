
using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrandBudapestHotel.Core
{
    public interface IValidData<T>
    {
        //generic interface
        bool Validate();
    }
}
