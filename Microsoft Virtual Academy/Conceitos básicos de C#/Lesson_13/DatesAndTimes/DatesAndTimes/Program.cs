﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());


            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1984,11,19);
            //Console.WriteLine(myBirthday.ToShortDateString());


            //DateTime myBirthday = DateTime.Parse("19/11/1984");
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            //Console.WriteLine(myBirthday.ToShortDateString());
            //Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
