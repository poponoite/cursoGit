using System;
using System.Collections.Generic;
using System.Globalization;

namespace Curso2
{
    class Program
    {

        //public static double dolar = 3.10;
        static void Main(string[] args)
        {

            DateTime data = DateTime.Now ;

      
            Console.WriteLine(data.ToShortDateString());
        }


    }
}
