using System;
using System.Collections.Generic;

namespace Calculator2
{
    public class Calculation
    {

        public static List<string> calculations = new List<string>(); // Tom lista där uträkningarna sparas.
   
        public static void CalculationMethod() // Metod med alla uträkningsalternativ 
        {
            double num1;
            double num2;
            char calculationMethod;
            double result;
            string calculationString;

 
            Console.WriteLine("\nChoose an operator: [ + - / * ]");
            ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
            Console.ForegroundColor = ConsoleColor.DarkGray; // Ändrar färgen på användarens input till darkgrey
            calculationMethod = Convert.ToChar(Console.ReadLine());
            Console.ForegroundColor = prevColor; // Byter tillbaka färgen på texten till prevColor
            Console.WriteLine("Enter a number: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = prevColor;
            Console.WriteLine("Enter a number: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = prevColor;

            switch (calculationMethod)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("\nResult: {0} {1} {2} = {3}\n", num1, calculationMethod, num2, result);
                    calculationString = Convert.ToString(num1 + " " + calculationMethod + " " + num2 + " " + "=" + " " + result); // Konverterar hela uträkningen till en string och lagrar värdet i calculationString
                    calculations.Add(calculationString); // Lägger till calculationString i listan calculations
                    WelcomeMessage.Line(); // Lägger till en dekorativ linje
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("\nResult: {0} {1} {2} = {3}\n", num1, calculationMethod, num2, result);
                    calculations.Add(Convert.ToString(num1 + " " + calculationMethod + " " + num2 + " " + "=" + " " + result));
                    WelcomeMessage.Line();
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("\nResult:{0} {1} {2} = {3}\n", num1, calculationMethod, num2, result);
                    calculationString = Convert.ToString(num1 + " " + calculationMethod + " " + num2 + " " + "=" + " " + result);
                    calculations.Add(calculationString); 
                    WelcomeMessage.Line();
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine("\nResult:{0} {1} {2} = {3}\n", num1, calculationMethod, num2, result);
                    calculationString = (Convert.ToString(num1 + " " + calculationMethod + " " + num2 + " " + "=" + " " + result));
                    calculations.Add(calculationString);
                    WelcomeMessage.Line();
                    break;
                default:
                    Console.WriteLine("Wrong input, please try again.");
                    break;
            }


            int userInput;
            bool loop = true;

            while (loop) 
            {
                Console.WriteLine("\nTo make more calculations press [1]");
                Console.WriteLine("Show a list off previous calculations press [2]");
                Console.WriteLine("To exit program press [3]");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = prevColor;

                if (userInput == 1)
                {
                    Console.Clear();
                    CalculationMethod();
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    PreviousCalculations(); 
                }
                else if (userInput == 3)
                {
                    WelcomeMessage.Line();
                    Console.WriteLine();
                    Console.WriteLine("\nThank you for using this calculator, see you another time!");
                    loop = false; 
                }

            } 

        }

        public static void PreviousCalculations()
        {
            WelcomeMessage.Line();
            Console.WriteLine();
            Console.WriteLine("Previous calculatios: ");
            foreach (string item in calculations)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            WelcomeMessage.Line();
        }

        // Först låg listan ej som static i metoden CalculationsMethod och även PreviousCalculations metoden låg ej som static i CalculationsMethod
        // Då sparades bara den senaste uträkningen i listan, ej flera uträkningar. Varför...?
        // Förslag på förbättringar - mer felhantering. 
    }
}
