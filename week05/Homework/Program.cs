using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Hinckley Owusu Ansah","The Bond Of 1844");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment homework1 = new MathAssignment("Hinckley","Fraction", "2.3.1","8-19");
        Console.WriteLine(homework1.GetSummary());
        Console.WriteLine(homework1.GetHomeworkList());

        //test writeassignment
        WritingAssignment writingwork1 = new WritingAssignment("Stepehen Adjetey","Ghana History","The Sagranti War");
        Console.WriteLine(writingwork1.GetSummary());
        Console.WriteLine(writingwork1.GetWritingInformation());
    }
}