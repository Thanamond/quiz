using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of stalls in the market: ");
        int numOfStalls = int.Parse(Console.ReadLine());

        bool[] reserved = new bool[numOfStalls];

        while (true)
        {
            Console.Write("Enter stall number 1: ");
            int stall1 = int.Parse(Console.ReadLine());

            Console.Write("Enter stall number 2: ");
            int stall2 = int.Parse(Console.ReadLine());

            // Handle negative input or input greater than the number of stalls
            if (stall1 <= 0 && stall2 <= 0)
            {
                Console.WriteLine("Invalid input. Program will now exit.");
                break;
            }
            else if (stall1 <= 0 || stall1 > numOfStalls)
            {
                stall1 = stall2;
            }
            else if (stall2 <= 0 || stall2 > numOfStalls)
            {
                stall2 = stall1;
            }

            // Handle same input
            if (stall1 == stall2)
            {
                stall2 = 0;
            }

            // Reserve stalls
            if (reserved[stall1 - 1] || reserved[stall2 - 1])
            {
                Console.WriteLine("The stall is reserved.");
            }
            else
            {
                reserved[stall1 - 1] = true;
                reserved[stall2 - 1] = true;
            }

            // Check for remaining stalls
            int remainingStalls = 0;
            foreach (bool isReserved in reserved)
            {
                if (!isReserved)
                {
                    remainingStalls++;
                }
            }

            // Handle only one stall left
            if (remainingStalls == 1)
            {
                Console.WriteLine("All stalls are reserved.");
                break;
            }
            else if (remainingStalls == 0)
            {
                Console.WriteLine("The entrance can’t be reserved.");
                break;
            }

            // Display stall status
            for (int i = 0; i < numOfStalls; i++)
            {
                Console.Write(reserved[i] ? "X" : "_");
            }
            Console.WriteLine();
        }
    }
}
