using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_ders
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;

        public Car(string brand, string model, ref double currentFuel, ref double fuelFor1Km, ref double millage)
        {
            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            FuelFor1Km = fuelFor1Km;
            Millage = millage;
        }

        public void Drive(int WantKm)
        {
            if (WantKm < CurrentFuel / FuelFor1Km)
            {
                Millage += WantKm;
                CurrentFuel -= WantKm * FuelFor1Km;
                Console.WriteLine("\nHazirki benzin:" + CurrentFuel + "\nMillage:" + Millage);
            }
            else
            {
                Console.WriteLine("Yolda qalacaqsiz");
            }
        }
        public void GetAllElement( string brand, string model,double currentFuel , double millage)
        {
            Console.WriteLine("Brand:" + Brand + "\nModel:" + Model + "\nHazirki benzin:" + CurrentFuel + "\nMillage:" + Millage);

        }
    }
}
