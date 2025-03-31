using System.ComponentModel.Design;

namespace Topic_1_to_7___Summative_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            int rock, paper, scissor, money, quit, userChoice, computerChoice, bet;
            bool done = false;
            rock = 1;
            paper = 2;
            scissor = 3;
            quit = 4;
            money = 1000;
            string ready;
            ready = "Yes";
            Console.WriteLine(" ____   ___     __  __  _      ____   ____  ____   ___  ____  \r\n|    \\ /   \\   /  ]|  |/ ]    |    \\ /    ||    \\ /  _]|    \\ \r\n|  D  )     | /  / |  ' /     |  o  )  o  ||  o  )  [_ |  D  )\r\n|    /|  O  |/  /  |    \\     |   _/|     ||   _/    _]|    / \r\n|    \\|     /   \\_ |     \\    |  |  |  _  ||  | |   [_ |    \\ \r\n|  .  \\     \\     ||  .  |    |  |  |  |  ||  | |     ||  .  \\\r\n|__|\\_|\\___/ \\____||__|\\_|    |__|  |__|__||__| |_____||__|\\_|\r\n                                                              \r\n  _____   __  ____ _____ _____  ___   ____   __               \r\n / ___/  /  ]|    / ___// ___/ /   \\ |    \\ |  |              \r\n(   \\_  /  /  |  (   \\_(   \\_ |     ||  D  )|  |              \r\n \\__  |/  /   |  |\\__  |\\__  ||  O  ||    / |__|              \r\n /  \\ /   \\_  |  |/  \\ |/  \\ ||     ||    \\  __               \r\n \\    \\     | |  |\\    |\\    ||     ||  .  \\|  |              \r\n  \\___|\\____||____|\\___| \\___| \\___/ |__|\\_||__|              ");
            Console.WriteLine("To choose from the four options type in the number beside them.");
            Console.WriteLine("Money: " + money + "$");
            Console.WriteLine("Play Rock, Paper, Scissor with me! (Type 'Yes' if ready.)");
            Console.WriteLine("Ready?");
            string ready1 = Console.ReadLine();
            if (ready == ready1)
            {
                Console.Clear();
                while (!done)
                {
                    Random random = new Random();
                    int randNum;
                    computerChoice = random.Next(1, 4);
                    Console.WriteLine("Alright!");
                    Console.WriteLine("Money: " + money);
                    Console.WriteLine("Place a bet!");
                    bet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose 1.Rock, 2.Paper, 3.Scissor, 4.Quit.");
                    Console.WriteLine();
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    if (userChoice == computerChoice)
                    {
                        Console.WriteLine("Tie, it's a push!");
                        Console.WriteLine("Computer chose " + computerChoice + "!");
                    }
                    else if (userChoice >= 5)
                    {
                        Console.WriteLine("Error, run program again");
                        done = true;
                    }
                    else if (userChoice == rock && computerChoice == scissor)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Nice!");
                        Console.WriteLine("You won!");
                        Console.WriteLine("Computer chose scissors!");
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("You have: ");
                        Console.WriteLine(money = money + bet);
                        Console.WriteLine();
                    }
                    else if (userChoice == paper && computerChoice == rock)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Nice!");
                        Console.WriteLine("You won!");
                        Console.WriteLine("Computer chose rock!");
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)\r\n");
                        Console.WriteLine("You have: ");
                        Console.WriteLine(money = money + bet);
                        Console.WriteLine();
                    }
                    else if (userChoice == scissor && computerChoice == paper)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Nice!");
                        Console.WriteLine("You won!");
                        Console.WriteLine("Computer chose paper!");
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)\r\n");
                        Console.WriteLine("You have: ");
                        Console.WriteLine(money = money + bet);
                        Console.WriteLine();
                    }
                    else if (userChoice == scissor && computerChoice == rock)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Wrong");
                        Console.WriteLine("You lost, try again!");
                        Console.WriteLine("Computer chose rock!");
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)\r\n ");
                        Console.WriteLine("You have: ");
                        Console.WriteLine(money = money - bet);
                        Console.WriteLine();
                    }
                    else if (userChoice == paper && computerChoice == scissor)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Wrong");
                        Console.WriteLine("You lost, try again!");
                        Console.WriteLine("Computer chose scissor!");
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("You have: ");
                        Console.WriteLine(money = money - bet);
                        Console.WriteLine();
                    }
                    else if (userChoice == rock && computerChoice == paper)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Wrong");
                        Console.WriteLine("You lost, try again!");
                        Console.WriteLine("Computer chose paper!");
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)\r\n");
                        Console.WriteLine("You have: ");
                        Console.WriteLine(money = money - bet);
                        Console.WriteLine();
                    }
                    else if (userChoice == 4)
                    {
                        Console.WriteLine("Thanks for trying!");
                        Console.WriteLine("  ____    _    __  __ _____    _____     _______ ____  \r\n / ___|  / \\  |  \\/  | ____|  / _ \\ \\   / / ____|  _ \\ \r\n| |  _  / _ \\ | |\\/| |  _|   | | | \\ \\ / /|  _| | |_) |\r\n| |_| |/ ___ \\| |  | | |___  | |_| |\\ V / | |___|  _ < \r\n \\____/_/   \\_\\_|  |_|_____|  \\___/  \\_/  |_____|_| \\_\\");
                        done = true;
                    }
                    else if (money == 0)
                    {
                        Console.WriteLine("  ____    _    __  __ _____    _____     _______ ____  \r\n / ___|  / \\  |  \\/  | ____|  / _ \\ \\   / / ____|  _ \\ \r\n| |  _  / _ \\ | |\\/| |  _|   | | | \\ \\ / /|  _| | |_) |\r\n| |_| |/ ___ \\| |  | | |___  | |_| |\\ V / | |___|  _ < \r\n \\____/_/   \\_\\_|  |_|_____|  \\___/  \\_/  |_____|_| \\_\\");
                        done = true;
                    }
                }
                }
            else
                {
                    Console.WriteLine("Run program to try again!");
                    Console.WriteLine("__   __\r\n\\ \\ / /\r\n \\ V / \r\n(_)_(_)\r\n / _ \\ \r\n| | | |\r\n| |_| |\r\n \\___/ ");
                }
            }
        }
    } 

