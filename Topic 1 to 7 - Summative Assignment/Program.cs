namespace Topic_1_to_7___Summative_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rock, paper, scissor, money, quit;
            bool done = false;
            rock = 1;
            paper = 2;
            scissor = 3;
            quit = 4;
            money = 100;
            string ready;
            ready = "Yes";
            Console.WriteLine("Rock, Paper, Sciccor!");
            Console.WriteLine("");
            Console.WriteLine("Instructions: Place a bet before playing the game, the game is Rock, Paper, Scissor");
            Console.WriteLine("To choose from the three options type in the number beside them.");
            Console.WriteLine("Game starts!");
            Console.WriteLine("You have 100 dollars!");
            Console.WriteLine("Money: " + money);
            int bet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Place a bet!");
            Console.WriteLine("Bet: " + bet);
            Console.WriteLine("Play Rock, Paper, Scissor with me! (Type 'Yes' if ready.)");
            Console.WriteLine("Ready?");
            string ready1 = Console.ReadLine();
            if (ready == ready1)
            {
                while (!done)
                {
                    Random random = new Random();
                    int randNum;
                    int num1 = random.Next(1, 4);
                    Console.WriteLine("Alright!");
                    Console.WriteLine("Choose 1.Rock, 2.Paper, 3.Scissor, 4.Quit.");
                    int answer1 = Convert.ToInt32(Console.ReadLine());
                    if (answer1 == num1)
                    {
                        Console.WriteLine("Nice!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                        done = true;
                    }

                }
            }
            else
            {
                Console.WriteLine("Run program to try again!");
            }
        }
    }
}
