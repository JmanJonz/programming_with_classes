using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<int> numList = new List<int>();
        int numEntered = 1;
        while (numEntered != 0)
        {
            Console.Write("Enter an integer (To stop enter the number 0): ");
            numEntered = int.Parse(Console.ReadLine());
            numList.Add(numEntered);
        }

        float runTot = 0;
        float avgOfNums = 0;
        float largest = 0;
        foreach (int num in numList)
        {
            runTot += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        avgOfNums = runTot / (numList.Count - 1);

        Console.WriteLine($"The sum of entered numbers is: {runTot}");
        Console.WriteLine($"The largest of the entered numbers is: {largest}");
        Console.WriteLine($"The average of the entered numbers is: {avgOfNums}");
    }
}