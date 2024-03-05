namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                //Createing a menu of choices for your user
                Console.WriteLine("**************");
                Console.WriteLine("");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");

                //prompting for and reading in the user’s choice as an integer
                Console.WriteLine("please make a selection:");
                int userChoice = int.Parse(Console.ReadLine());
            //while loop
            while (userChoice == 4)
            {
               
                //application printing an appropriate response confirming their choice
                if (userChoice == 1)
                {
                    Console.WriteLine("Loading New Game ...");
                }
                if (userChoice == 2)
                {
                    Console.WriteLine("Loading Game ...");
                }
                if (userChoice == 3)
                {
                    Console.WriteLine("Loading Options ...");
                }
                if (userChoice == 4)
                {
                    Console.WriteLine("Quiting game ...");
                }
                Console.WriteLine("**************");
                Console.WriteLine("");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                Console.WriteLine("please make a selection:");
            }
        }
    }
}