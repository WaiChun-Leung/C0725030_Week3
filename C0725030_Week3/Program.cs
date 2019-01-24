using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030_Week3
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level 2");
        }

        public int CalculateRating()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            

            //Car purple = new Car(); result is "red"
            //Vechicle dog_and_cat = new Car(); result is "red"
            //var dog_and_cat = new Car(); result is "red"
            //var bowling = new Car();
            //Console.WriteLine("How many cars: {0}", Vechicle.howManyCars);

            //create a book object
            //1.set the title
            //2.get the title
            //Book myBook = new Book();
            //myBook.SetTitle ("A Separate Peace");
            //Console.WriteLine(myBook.GetTitle());

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
    class BookCollection
    {
        
    }
    class Book : BookCollection
    {
        private String Title; //hide the data
        public void SetTitle(String aTitle) { this.Title = aTitle; }
        public String GetTitle() { return this.Title; }
    }
}
