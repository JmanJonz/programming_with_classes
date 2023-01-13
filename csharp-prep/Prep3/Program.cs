using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGeneratorrrr = new Random();
        int magicNum = randomGeneratorrrr.Next(1,101);
        int actGuess = 2;
            Console.WriteLine("A random number has been generated now try to guess it! ");

        while (magicNum != actGuess)
        {
            Console.Write("What is your guess? ");
            string actGuessstr = Console.ReadLine();
            actGuess = int.Parse(actGuessstr);
            if (magicNum > actGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < actGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}