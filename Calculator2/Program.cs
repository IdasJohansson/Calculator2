using System;
using System.Collections.Generic;

namespace Calculator2
{

    class Program
    {
        static void Main(string[] args)
        {
            
            WelcomeMessage.StartMessage();

            Calculation.CalculationMethod();

            Console.WriteLine("Enter any key to exit program...\n");
            Console.ReadKey();



        }
    }
}



