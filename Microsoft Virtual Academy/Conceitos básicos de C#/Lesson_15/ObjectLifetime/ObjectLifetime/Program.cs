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
            Car myCar = new Car("Oldmobile", "Cutlas Supreme", 1986, "Silver");
            Car myOtherCar = myCar;
            Car myThirdCar = new Car();
            Car myVirtualCar = new Car(myCar);


            //Console.WriteLine("      My Car: " + myCar.toString());
            //Console.WriteLine("My Other Car: " + myOtherCar.toString());
            //Console.WriteLine("  Not My Car: " + myVirtualCar.toString());

            //myOtherCar.Model = "98";
            //Console.WriteLine("      My Car: " + myCar.toString());
            //Console.WriteLine("My Other Car: " + myOtherCar.toString());
            //Console.WriteLine("  Not My Car: " + myVirtualCar.toString());


            //myOtherCar = null;
            //Console.WriteLine("      My Car: " + myCar.toString());
            //Console.WriteLine("My Other Car: " + myOtherCar.toString());
            //Console.WriteLine("  Not My Car: " + myVirtualCar.toString());


            //myCar = null;
            //Console.WriteLine("      My Car: " + myCar.toString());
            //Console.WriteLine("My Other Car: " + myOtherCar.toString());
            //Console.WriteLine("  Not My Car: " + myVirtualCar.toString());


            Console.ReadLine();
        } //End Main



    } //End Class Program



    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car() { }
        
        public Car(Car car)
        {
            Make = car.Make;
            Model = car.Model;
            Year = car.Year;
            Color = car.Color;
        }
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public string toString()
        {
            return Make + " " + Model + " " + Year + " " + Color;
        }
    }//End Class Car




}//End Name Space
