using System;
namespace Calculator2
{
    public class WelcomeMessage
    {

        public static void StartMessage()
        {
            

            Console.WriteLine(@"
   ____      _            _       _             
  / ___|__ _| | ___ _   _| | __ _| |_ ___  _ __ 
 | |   / _` | |/ __| | | | |/ _` | __/ _ \| '__|
 | |__| (_| | | (__| |_| | | (_| | || (_) | |   
  \____\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|   
                                                
");
            Console.WriteLine();
            Console.Write("Hello, enter your name: ");

            ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
            Console.ForegroundColor = ConsoleColor.DarkGray; // Byter färg på texten till DarkGray

            string name = Console.ReadLine();
            Console.ForegroundColor = prevColor; // Byter tillbaka färgen på texten till prevColor

            string nameBigLetter = Char.ToUpper(name[0]) + name.Substring(1); // Gör att användarens inskrivna namn skrivs ut med stor bokstav även om man skriver in namnet med liten bokstav. 

            Console.WriteLine("Welcome, {0}!", nameBigLetter);
            Console.WriteLine("In this simple caulculator you will be asked to choose a calculation method and then choose two numbers to make a calulation.");
            Console.WriteLine("Let's get started! \n");
            Line();
        }

        public static void Line()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("============================================================================================================================");
            Console.ForegroundColor = prevColor;
        }

    }
}
