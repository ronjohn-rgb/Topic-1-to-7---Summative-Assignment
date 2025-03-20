namespace Topic_1_to_7___Summative_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            int rock, paper, scissor, money, quit;
            bool done = false;
            rock = 1;
            paper = 2;
            scissor = 3;
            quit = 4;
            money = 1000;
            string ready;
            ready = "Yes";
            Console.WriteLine("Rock, Paper, Sciccor!");
            Console.WriteLine("");
            Console.WriteLine("Instructions: Place a bet before playing the game, the game is Rock, Paper, Scissor");
            Console.WriteLine("To choose from the four options type in the number beside them.");
            Console.WriteLine("Game starts!");
            Console.WriteLine("You have 1000 dollars!");
            Console.WriteLine("Money: " + money + "$");         
            Console.WriteLine("Place a bet!");
            Console.WriteLine("Max bet is 750$");
            int bet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bet: " + bet + "$");
            if (bet >= 750)
            {
                Console.WriteLine("I said max bet 750$ silly boy!");
            }
            Console.WriteLine("Play Rock, Paper, Scissor with me! (Type 'Yes' if ready.)");
            Console.WriteLine("Ready?");
            string ready1 = Console.ReadLine();
            if (ready == ready1)
            {
                while (!done)
                {
                    money = 100;
                    Random random = new Random();
                    int randNum;
                    int num1 = random.Next(1, 4);
                    Console.WriteLine("Alright!");
                    Console.WriteLine("Choose 1.Rock, 2.Paper, 3.Scissor, 4.Quit.");
                    double answer1 = Convert.ToInt32(Console.ReadLine());
                   
                    if (answer1 == num1)
                    {
                        int frequency, length;
                        frequency = 800;
                        length = 1500;
                        Console.Beep(frequency, length);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Nice!");
                        Console.WriteLine("You won!");
                        Console.WriteLine("It was " + num1 + "!");
                        Console.WriteLine("You have " + (money + bet) + "$");
                    }
                    if (answer1 != num1)
                    {
                        int frequency, length;
                        frequency = 1500;
                        length = 1500;
                        Console.Beep(frequency, length);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Wrong");
                        Console.WriteLine("You lost, try again!");
                        Console.WriteLine("It was " + num1 + "!");
                        Console.WriteLine("You have " + (money - bet) + "$ left!");
                    }   
                    if (answer1 == 4)
                    {
                        Console.WriteLine("Thanks for trying!");
                    }
                }
                if (money == 0)
                    {
                        bool loop = true;
                    }
            }
            else
            {
                Console.WriteLine("Run program to try again!");
            }
        }
    }
}
