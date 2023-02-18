using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testA = new Assignment("Bobby", "growing up");
        Console.WriteLine(testA.GetSummary());

        Console.WriteLine("");

        MathAssignment testB = new MathAssignment("Bobby", "Butterflied", "Mathflied", "8-3456");
        Console.WriteLine(testB.GetSummary());
        Console.WriteLine(testB.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment testC = new WritingAssignment("Bobby Smith", "Eating Grass", "Grass Salad");
        Console.WriteLine(testC.GetSummary());
        Console.WriteLine(testC.GetWritingInformation());

    }
}