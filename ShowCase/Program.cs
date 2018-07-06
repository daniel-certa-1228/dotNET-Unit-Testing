using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 20)
                ResetConsole();
            Console.WriteLine("Enter a word and I will tell you if it begins with an uppercase character.");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                              $"{(input.StartsWithUpper() ? "Yes" : "No")}\n");
            row += 3;
        } while (true);
        return;

        //Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to clear the console and continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine();
            row = 3;
        }
    }
}

