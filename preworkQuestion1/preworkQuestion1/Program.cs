using System;

namespace preworkQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please choose a number between 1 and 10: ");
            int chosenNumber;
            chosenNumber = Convert.ToInt32(Console.ReadLine());

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
            Console.Write("You chose " +chosenNumber+" and your score is "+chosenNumber*count +".");
            Console.Read();

        }


    }
}
