using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneOne = new Fraction();
        Fraction customTop = new Fraction(6);
        Fraction allCustom = new Fraction(6,7);

        // Setter and Getter
        Console.WriteLine("Test Getters and setters:");
        Console.WriteLine(oneOne.GetTop());
        oneOne.SetTop(2);
        Console.WriteLine(oneOne.GetTop());
        oneOne.SetBottom(3);
        Console.WriteLine(oneOne.GetBottom());
        Console.WriteLine("");
        oneOne.SetTop(1);
        oneOne.SetBottom(1);

        // Different Tests
        Console.WriteLine(oneOne.GetFractionString());
        Console.WriteLine(oneOne.GetDecimalValue());
        Console.WriteLine(customTop.GetFractionString());
        Console.WriteLine(customTop.GetDecimalValue());
        Console.WriteLine(allCustom.GetFractionString());
        Console.WriteLine(allCustom.GetDecimalValue());
    
        
    }
}