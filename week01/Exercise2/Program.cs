using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What grade did you obtain? ");
        string userInput=Console.ReadLine();
        int grade=int.Parse(userInput);
        Console.WriteLine(grade);
        if (grade >= 90)
        {
            string letter = "A";
            Console.WriteLine(letter);
        }
        else if(grade >=80)
        {
            string letter = "B";
            Console.WriteLine(letter);
            }
        else if(grade >=70)
        {
            string letter = "C";
            Console.WriteLine(letter);
            }
        else if(grade >=60)
        {
            string letter = "D";
            Console.WriteLine(letter);
            }
        else 
        {
            string letter = "F";
            Console.WriteLine(letter);
        }

        if (grade>=70)
        {
            Console.WriteLine("Congratulations, you have passed");
        }
        else
        {
            Console.WriteLine("There is more room for improvement");
        }

    }
}