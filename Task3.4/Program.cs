using System;

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
           bool isWorking = true;
            string input;
            int[] arrayOfNumbers = new int[0];
            Console.WriteLine("sum для сложения\nexit для выхода\n");

            while (isWorking)
            {

                switch (input = Console.ReadLine().ToLower().Trim())
                {
                    case "sum":
                        int sum = 0;

                        for (int i = 0; i < arrayOfNumbers.Length; i++)
                        {
                            sum += arrayOfNumbers[i];
                        }

                        Console.WriteLine($"Сумма введеных чисел: {sum}\n");
                        break;
                    case "exit":
                        isWorking = false;
                        break;
                    default:
                        int[] copyArray = new int[arrayOfNumbers.Length + 1];
                        int number = Convert.ToInt32(input);
                        copyArray[copyArray.Length - 1] = number;

                        for (int i = 0; i < arrayOfNumbers.Length; i++)
                            copyArray[i] = arrayOfNumbers[i];
                        arrayOfNumbers = copyArray;
                        break;
                }
            }
        }
    }
}
