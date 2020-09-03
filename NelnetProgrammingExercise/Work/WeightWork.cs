using System;
using System.Collections.Generic;
using System.Text;
using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise
{
    public class WeightWork
    {
        public static PetSize weightWork(double weight)
        {
            if (weight > 0 && weight <= 1.0)
            {
                return PetSize.ExtraSmall;
            }
            if (weight > 1.0 && weight <= 5.0)
            {
                return PetSize.Small;
            }
            if (weight > 5.0 && weight <= 15.0)
            {
                return PetSize.Medium;
            }
            if (weight > 15.00 && weight <= 30.0)
            {
                return PetSize.Large;
            }
            else return PetSize.ExtraLarge;
        }

    }
}
