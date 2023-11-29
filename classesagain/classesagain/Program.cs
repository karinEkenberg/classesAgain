using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

         /*   myCar.Make = "audi";
            myCar.Model = "2000";
            myCar.Year = 1986;
            myCar.Color = "blue";
         

            Car car = new Car("Volvo", "rullar", 2010, "green");

            Car myOtherCar;
            myOtherCar = myCar;
            
            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
         */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

      /*  public Car()
        {
            // You could load from a configuration file,
            // a database, etc.
            Make = "volvo";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;

        }
      */

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            Console.WriteLine(Make);
        }
    }
}
