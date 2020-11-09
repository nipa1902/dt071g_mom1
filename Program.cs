using System;

namespace moment1 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello world print
            //Console.WriteLine("Hello, World!");

            // Request user input, save string as variable
            Console.WriteLine("\nWhich is the greatest of all the cats?");
            var catname = Console.ReadLine();
            
            // Check for correct string answer
            if (catname == "Boxkat") {
                Console.WriteLine("You have chosen wisely. Well done!");
                Console.Write("\nPress any key to exit...");

                //The program wants to close, but we wait for a key input first.
                Console.ReadKey(true);
            } 
            // Wrong answer
            else {
                Console.WriteLine("This is incorrect. The greatest of all cats is Boxkat. Goodbye.");
            }
        }
    }
}
