using System;

namespace preworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please choose a number between 1 and 10: ");
            int chosenNumber;
            chosenNumber = Convert.ToInt32(Console.ReadLine());
            Q1(chosenNumber);

            Console.Write("Please choose a year: ");
            int chosenYear;
            chosenYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is " + chosenYear + " a leap year?");
            Q2(chosenYear);


            Console.Read();


        }

        private static void Q1(int chosenNumber)
        {

            int[] random = new int[5];
            Random randNum = new Random();
            for (int i = 0; i < random.Length; i++)
            {
                random[i] = randNum.Next(1, 10);
            }

            int count = 0;
            for (int i = 0; i < random.Length; i++)
            {
                if (random[i] == chosenNumber)
                {
                    count++;
                }
            }
            for (int i = 0; i < random.Length; i++)
            {
                Console.Write(random[i]);
            }
            Console.WriteLine("You chose " + chosenNumber + " and your score is " + chosenNumber * count + ".");
        }

        public static string Q2(int chosenYear)
        {
            if(chosenYear % 4 == 0 && !(chosenYear % 100 == 0 && chosenYear % 400 != 0))
            {
                Console.WriteLine(" Yes.");
                return "yes";
            }
            else
            {
                Console.WriteLine(" No.");
                return "no";
            }

        }
    }
}
