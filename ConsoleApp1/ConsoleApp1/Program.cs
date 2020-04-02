using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char menuChoice;
            int[] userLottoMax = new int [RandomNumberMax()];
            int[] winningLottoMax = new int[RandomNumberMax()];
            int[] userLotto649 = new int[RandomNumber649Extra()];
            int[] winningLott649 = new int[RandomNumber649Extra()];
            int[] userLottoExtra = new int[RandomNumber649Extra()];
            int[] winningLottoExtra = new int[RandomNumber649Extra()];

            do {
                Console.Clear();
                MenuPrint();
                Console.Write("\nEnter your menu choice > ");
                menuChoice = char.Parse(Console.ReadLine());
                switch (menuChoice) {
                    case '1': LottoMaxNumbers(userLottoMax, winningLottoMax); break;
                    case '2': Lotto649Numbers(); break;
                    case '3': LottoExtraNumbers(); break;
                    case '4': PlayLottoMax(); break;
                    case '5': PlayLotto649(); break;
                    case '0': break;
                }
            }
            while (menuChoice != '0');
            Console.WriteLine("Good-bye and thanks for coming to the CPSC1012 Lotto Centre.");
        }


        static void MenuPrint()
        {
            Console.WriteLine("| ------------------------------------------------|");
            Console.WriteLine("| CPSC1012 Lotto Centre                           |");
            Console.WriteLine("| ------------------------------------------------|");
            Console.WriteLine("| 1.Change player’s Lotto MAX numbers             |");
            Console.WriteLine("| 2.Change player’s Lotto 6 / 49 numbers          |");
            Console.WriteLine("| 3.Change player’s Lotto EXTRA numbers           |");
            Console.WriteLine("| 4.Play Lotto MAX                                |");
            Console.WriteLine("| 5.Play Lotto 6 / 49                             |");
            Console.WriteLine("| 0.Exit Program                                  |");
            Console.WriteLine("| ------------------------------------------------|");
        }
        static void LottoMaxNumbers(int[] userLottoMax, int[] winningLottoMax)
        {
            Console.WriteLine("Your current Lotto MAX Numbers are {1}, {2}, {3}, {4}, {5}, {6}, {7}, and bonus number {8}.", userLottoMax[1], userLottoMax[2], userLottoMax[3], userLottoMax[4], userLottoMax[5], userLottoMax[6], userLottoMax[7], userLottoMax[8]);
            Console.Write("Would you like to generate or enter your numbers? (g/e): ");
            char menuChoice = Char.Parse(Console.ReadLine());
                if (menuChoice == 'g') 
            {

            }
                else
            {
                Console.Write("\nEnter number #1: ");
                LottoMaxNumbers[1] = int.parse(Console.ReadLine());
                Console.Write("\nEnter number #2: ");
                Console.Write("\nEnter number #3: ");
                Console.Write("\nEnter number #4: ");
                Console.Write("\nEnter number #5: ");
                Console.Write("\nEnter number #6: ");
                Console.Write("\nEnter number #7: ");
            }
        }
        static void Lotto649Numbers()
        {

        }
        static void LottoExtraNumbers()
        {

        }
        static void PlayLottoMax()
        {

        }
        static void PlayLotto649()
        {

        }
        static int RandomNumberMax()
        {
            return 0;
        }
        static int RandomNumber649Extra()
        {
            return 5;
        }
    }
}
