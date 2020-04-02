using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char menuChoice = '9';
            int[] userLottoMax = new int[7]; int firstMaxNumber = 50;
            RandomNumber(userLottoMax, firstMaxNumber);
            int[] winningLottoMax = new int[8];
            RandomNumber(winningLottoMax, firstMaxNumber);
            int[] userLotto649 = new int[6]; int secondMaxNumber = 49;
            RandomNumber(userLotto649, secondMaxNumber);
            int[] winningLotto649 = new int[7];
            RandomNumber(winningLotto649, secondMaxNumber);
            int[] userLottoExtra = new int[7]; int thirdMaxNumber = 9;
            RandomNumber(userLottoExtra, thirdMaxNumber);
            int[] winningLottoExtra = new int[7];
            RandomNumber(winningLottoExtra, thirdMaxNumber);

            do {
                MenuPrint();
                Console.Write("\nEnter your menu choice > ");
                menuChoice = GetUserChar(menuChoice);
                switch (menuChoice) {
                    case '1': LottoMaxNumbers(userLottoMax); break;
                    case '2': Lotto649Numbers(userLotto649); break;
                    case '3': LottoExtraNumbers(userLottoExtra); break;
                    case '4': PlayLottoMax(userLottoMax, winningLottoMax, userLottoExtra, winningLottoExtra); break;
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
        static void LottoMaxNumbers(int[] userLottoMax)
        {
            Char menuChoice = 'p';
            Console.WriteLine("Your current Lotto MAX Numbers are {0}, {1}, {2}, {3}, {4}, {5}, and {6}", userLottoMax[0], userLottoMax[1], userLottoMax[2], userLottoMax[3], userLottoMax[4], userLottoMax[5], userLottoMax[6]);
            Console.Write("Would you like to generate or enter your numbers? (g/e): ");
            menuChoice = GetUserChar(menuChoice);
            if (menuChoice == 'g') {
                int maxNumber = 50;
                RandomNumber(userLottoMax, maxNumber);
                Console.WriteLine("Your new Lotto MAX Numbers are {0}, {1}, {2}, {3}, {4}, {5}, and {6}.\n", userLottoMax[0], userLottoMax[1], userLottoMax[2], userLottoMax[3], userLottoMax[4], userLottoMax[5], userLottoMax[6]);
            }
            else if (menuChoice == 'e') {
                Console.Write("\nEnter number #1: ");
                userLottoMax[0] = GetUserInt(userLottoMax[0]);
                Console.Write("\nEnter number #2: ");
                userLottoMax[1] = GetUserInt(userLottoMax[1]);
                Console.Write("\nEnter number #3: ");
                userLottoMax[2] = GetUserInt(userLottoMax[2]);
                Console.Write("\nEnter number #4: ");
                userLottoMax[3] = GetUserInt(userLottoMax[3]);
                Console.Write("\nEnter number #5: ");
                userLottoMax[4] = GetUserInt(userLottoMax[4]);
                Console.Write("\nEnter number #6: ");
                userLottoMax[5] = GetUserInt(userLottoMax[5]);
                Console.Write("\nEnter number #7: \n");
                userLottoMax[6] = GetUserInt(userLottoMax[6]);
            }
        }
        static void Lotto649Numbers(int[] userLotto649)
        {
            Char menuChoice = 'p';
            Console.WriteLine("Your current Lotto 6/49 Numbers are {0}, {1}, {2}, {3}, {4}, and {5}.", userLotto649[0], userLotto649[1], userLotto649[2], userLotto649[3], userLotto649[4], userLotto649[5]);
            Console.Write("Would you like to generate or enter your numbers? (g/e): ");
            menuChoice = GetUserChar(menuChoice);
            if (menuChoice == 'g') {
                int maxNumber = 49;
                RandomNumber(userLotto649, maxNumber);
                Console.WriteLine("Your new Lotto 6/49 Numbers are {0}, {1}, {2}, {3}, {4}, and {5}.\n", userLotto649[0], userLotto649[1], userLotto649[2], userLotto649[3], userLotto649[4], userLotto649[5]);
            }
            else if (menuChoice == 'e') {
                Console.Write("\nEnter number #1: ");
                userLotto649[0] = GetUserInt(userLotto649[0]);
                Console.Write("\nEnter number #2: ");
                userLotto649[1] = GetUserInt(userLotto649[1]);
                Console.Write("\nEnter number #3: ");
                userLotto649[2] = GetUserInt(userLotto649[2]);
                Console.Write("\nEnter number #4: ");
                userLotto649[3] = GetUserInt(userLotto649[3]);
                Console.Write("\nEnter number #5: ");
                userLotto649[4] = GetUserInt(userLotto649[4]);
                Console.Write("\nEnter number #6: ");
                userLotto649[5] = GetUserInt(userLotto649[5]);

            }
        }
        static void LottoExtraNumbers(int[] userLottoExtra)
        {
            Console.WriteLine("Your current Lotto Extra Number is {0}{1}{2}{3}{4}{5}{6}.", userLottoExtra[0], userLottoExtra[1], userLottoExtra[2], userLottoExtra[3], userLottoExtra[4], userLottoExtra[5], userLottoExtra[6]);
            int maxNumber = 9;
            RandomNumber(userLottoExtra, maxNumber);
            Console.WriteLine("Your new Lotto Extra Number is {0}{1}{2}{3}{4}{5}{6}.\n", userLottoExtra[0], userLottoExtra[1], userLottoExtra[2], userLottoExtra[3], userLottoExtra[4], userLottoExtra[5], userLottoExtra[6]);
        }
        static void PlayLottoMax(int[] userLottoMax, int[] WinningLottoMax, int[] userLottoExtra, int[] winningLottoExtra)
        {
            SearchArray1(userLottoMax, WinningLottoMax);
        }
        static void PlayLotto649()
        {
            PlayLottoExtra();
        }
        static void PlayLottoExtra()
        {

        }
        static int RandomNumber(int[] arraySize, int maxNumber)
        {
            Random keygen = new Random();
            for (int index = 0; index < arraySize.Length; index++)
            {
                arraySize[index] = keygen.Next(1, maxNumber);
            }
            return maxNumber;
        }
        static int GetUserInt(int userInt)
        {
            try
            {
                userInt = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Input.");
            }
            return userInt;
        }
        static char GetUserChar(char userChar)
        {
            try
            {
                userChar = char.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Input.");
            }
            return userChar;
        }
        static int SearchArray1(int[] userLotto, int[] winningLotto)
        {
            int matchingNumbers = 0;
            for (int index = 0; index < userLotto.Length; index++)
            {
                if (userLotto[] == winningLotto[index])
                    matchingNumbers = matchingNumbers + 1;
                return matchingNumbers;
            } // logic for comparing values, logic for comparing to bonus value. logic for presenting values. No duplicate numbers. Sort numbers. 
        }
    }
}
