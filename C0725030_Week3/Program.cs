using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030_Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car purple = new Car(); result is "red"
            //Vechicle dog_and_cat = new Car(); result is "red"
            var dog_and_cat = new Car(); //result is "red"
            var bowling = new Car();
            Console.WriteLine("How many cars: {0}", Vechicle.howManyCars);
        }
    }
    class Vechicle
    {
        public static int howManyCars = 0;
        public String Color = "Blue";
    }
    class Car : Vechicle
    {
        public String Color = "Red";
        public Car()
        {
            Vechicle.howManyCars++;
            Console.WriteLine("My color is " + Color);
        }
    }
}
