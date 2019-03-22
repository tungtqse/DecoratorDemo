using DecoratorDemo.StarBuckDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunStarBuck();
        }

        public static void Run()
        {
            // Create book

            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video

            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display

            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            // Wait for user

            Console.ReadKey();
        }

        public static void RunStarBuck()
        {
            Console.WriteLine("StarBuck Coffe Order: ");

            Beverage beverage = new Espresso();

            Console.WriteLine(string.Format("{0} : ${1}", beverage.GetDescription(), beverage.GetCost()));

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new SteamMilk(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(string.Format("{0} : ${1}", beverage2.GetDescription(), beverage2.GetCost()));
        }
    }
}
