using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction= new Fraction(1);
        // Accessing values using getters
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());

        Fraction myFraction2= new Fraction(2);
        // Accessing values using getters
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());

        Fraction myFraction3= new Fraction(3,4);
        // Accessing values using getters
        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetDecimalValue());

        Fraction myFraction4= new Fraction(1,3);
        // Accessing values using getters        
        Console.WriteLine(myFraction4.GetFractionString());
        Console.WriteLine(myFraction4.GetDecimalValue());

        Fraction myFraction5= new Fraction(30,200);
        // Accessing values using getters
        Console.WriteLine(myFraction5.GetFractionString());
        Console.WriteLine(myFraction5.GetDecimalValue());

    }

}