using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            //LINQ query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
             */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */





            //LINQ method
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            /*
            //var firstBMW = myCars.First(p => p.Make == "BMW");
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            */

            // É verade que os meus carros são todos depois de 2012
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            // É verade que os meus carros são todos depois de 2007
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            //foreach usando a função Lambda
            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //existe algum carro do modelo "745li"?
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //Quanto dinheiro tenho em carros
            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));




            //Funções de escrita a "moda antiga"
            /*
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}",car.Model,car.VIN);
            }
            */
            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model);
            }
            */

            //Console.WriteLine(firstBMW.VIN);
            /*
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());


            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year == 2010
                          select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());
            */



            var books = new List<Book>() {
                new Book { ISBN = "978-1455509126", Title = "Tão Bom que Ninguém Consegue Ignorar", Author = "Cal Newport", Category="Autoajuda", Year=2013},
                new Book { ISBN = "978-0465050659", Title = "O Design do Dia a Dia", Author = "Don Norman", Category="Design", Year=2013},
                new Book { ISBN = "978-0321965516", Title = "Não Me Faça Pensar", Author = "Steve Krug", Category="Design", Year=2014},
                new Book { ISBN = "978-1594484803", Title = "Dirigir", Author = "Daniel Pink", Category="Autoajuda", Year=2011}
            };

            var myBooks = books.Where(p => p.Year == 2013).OrderBy(p => p.Title);

            foreach (var book in myBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
    }

}
