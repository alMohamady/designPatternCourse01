using singleton.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = null;

            Console.WriteLine("Select Your Type S=Sedan, U=SUV, T=Truck ??");
            string type = Console.ReadLine();

            //car = (new CarFactory()).getYourCar(type);

            //runCommand(car);

            AbstractFactory af = new CarFactory();

            car = af.getYourCar(type);
            af.drowTire(type);
            runCommand(car);

            Console.ReadKey(true);
        }

        static void runCommand(Car car)
        {
            car.RunCar();
            car.ShowCar();
        }
    }
}
