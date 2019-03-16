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
            Q1(chosenNumber);

            Console.Write("Please choose a year: ");
            int chosenYear;
            chosenYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is " + chosenYear + " a leap year?");
            Q2(chosenYear);

            Console.Write("Please choose 3 numbers: ");
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Is this a perfect sequence?");
            Q3(array);

            Console.Write("Please choose the length of your multidimensional array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please choose the width of your multidimensional array: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int[,] chosenArray = new int[width, length];

            //to fill the chosen array with numbers from the user.
            Console.Write("Please choose the numbers inside your multidimensional array: ");
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    chosenArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("The sums of all the ints inside each of your arrays at each level are: ");
            Q4(chosenArray);

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

        public static string Q3(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    Console.WriteLine(" No.");
                    return "no";
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if (product == sum)
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

       public static int[] Q4(int[,] chosenArray)
       {
            int chosenArrayLength = chosenArray.GetLength(1);
            int chosenArrayWidth = chosenArray.GetLength(0);

            int[] sums = new int[chosenArrayWidth];
            
            for (int i = 0; i < chosenArrayWidth; i++)
            {
                for (int j = 0; j < chosenArrayLength; j++)
                {
                    sums[i] += chosenArray[i,j];
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", sums));
            return sums;
        }

    }
}
