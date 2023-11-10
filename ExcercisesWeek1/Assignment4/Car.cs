using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisesWeek1.Assignment4
{
    public class Car : IVehicle
    {
        public int GasolineAmount { get; set; }

        public Car(int gasolineAmount)
        {
            GasolineAmount = gasolineAmount;
        }

        public void Drive()
        {
            if (GasolineAmount > 0)
                Console.WriteLine("Car is driving");
        }

        public bool Refuel(int amountOfGasoline)
        {
            GasolineAmount += amountOfGasoline;
            return true;
        }
    }
}
