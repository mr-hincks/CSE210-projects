using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

    Random randomGenerator = new Random();
    int magic = randomGenerator.Next(1, 101);
    int guess = -1;
    while(guess != magic)
    {
        Console.Write("What is your guess? ");
        int number=int.Parse(Console.ReadLine());
    
    
        if(number < magic )
        {
        Console.WriteLine("Higher");
        }
        else if(number > magic)
        {
        Console.WriteLine("Lower");
        }
        else
        {
        Console.WriteLine("You guessed it!");
        break;
        }     
    
    }
    

    
    



    }
}