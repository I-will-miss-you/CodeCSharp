using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{

    // Declare the generic class.
    public class GenericList<T>
    {
        void Add(T input) {}
    }

    class Program
    {
        private class ExampleClass { }

        static void Main(string[] args)
        {
            //List<int> num = new List<int>(); //is a generic list
            //num.Add(10);
            //num.Add(20);
            //num.Add(30);

            // Microsoft Documentation: < Generics > 
            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();

            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();


            Console.ReadLine();
        }
    }
}
