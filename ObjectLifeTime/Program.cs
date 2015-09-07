using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Ford", "Escape", 2000, "Blue");

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            //You could do this from a configuration file, a database, etc.
            // i´ll just hardcode in this instance

            this.Make = "Nissan";
            Car.myMethod();

        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public Car(string someOtherInputParameter,string make, string model, int year, string color)
        {
            Make = someOtherInputParameter;
            Model = model;
            Year = year;
            Color = color;
        }

        static void myMethod()
        {

        }

    }
}
