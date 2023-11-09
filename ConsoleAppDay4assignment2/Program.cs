using System;

class Program
{
    static void Main()
    {
        // Using a for loop to display the first 10 natural numbers
        Console.WriteLine("First 10 natural numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Using a while loop to print the first 2 even natural numbers
        Console.WriteLine("First 2 even natural numbers:");
        int evenCount = 0;
        int number = 1;
        while (evenCount < 2)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
                evenCount++;
            }
            number++;
        }
        Console.WriteLine();

        // Using a do-while loop to print the first 10 odd natural numbers
        Console.WriteLine("First 10 odd natural numbers:");
        int oddCount = 0;
        int oddNumber = 1;
        do
        {
            if (oddNumber % 2 != 0)
            {
                Console.Write(oddNumber + " ");
                oddCount++;
            }
            oddNumber++;
        } while (oddCount < 10);
        Console.WriteLine();
    }
}

