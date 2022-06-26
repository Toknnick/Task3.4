using System;

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            int sizeOfArray = 10;
            string input;
            int number;
            int sum = 0;
            int repeat = 0;
            int[] arrayOfNumbers = new int[sizeOfArray];
            Console.WriteLine("sum для сложения\nexit для выхода\n\nВводите числа");

            while (isWorking)
            {
                switch (input = Console.ReadLine().ToLower().Trim())
                {
                    case "sum":

                        for (int i = 0; i < arrayOfNumbers.Length; i++)
                        {
                            sum += arrayOfNumbers[i];
                        }

                        Console.WriteLine(sum + " sum");
                        break;
                    case "exit":
                        isWorking = false;
                        Console.Clear();
                        break;
                    default:
                        number = int.Parse(input);
                        arrayOfNumbers[repeat] = number;
                        repeat++;
                        break;
                }
            }
        }
    }
}
