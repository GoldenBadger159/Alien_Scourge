using System;

class Program
{
    private static Explore e = new Explore();
    static void Main(string[] args)
    {
        Console.WriteLine("The apocalypse started 50 years ago. Aliens from a distant planet invaded, destroying society as we knew it.");
        Console.WriteLine("The invasion is over now, but many of the aliens still remain. Their social structure is ");
        Console.WriteLine("completely different from our own; Each memeber of their species lives in solitude except when mating. ");
        Console.WriteLine("Because of this it is possible to hunt them. It is your job to hunt them. Now where would you like to start?");
        Console.WriteLine("You must find supplies to fight the alien scourge.");
        bool quit = false;
        do {
            Console.WriteLine("If you would like to continue press enter. If not type 'quit'");
            string choice = Console.ReadLine();
            if (choice == "quit")
            {
                quit = true;
            } else {
                e.GoExploring();
            }
            
        } while (quit == false);
       
    }
}