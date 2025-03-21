using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int>numbers=new List<int>();
        int user = 1;
        while(user != 0)
        {
            Console.Write($"Enter number: ");
            user=int.Parse(Console.ReadLine());
            if(user !=0)
            {
                numbers.Add(user);

            }
        }    
            //compute the sum
            int sum=0;
            foreach (int number in numbers)
            {
                sum +=number;

            }
            Console.WriteLine($"The sum is: {sum}");

            //compute the average
            float average = ((float)sum)/numbers.Count;
            Console.WriteLine($"The average is: {average}");    
            
            int max=numbers[0];
            foreach (int number in numbers)
            {
                if(number>max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The maximum number is : {max}");

        }
    }
       
        

    
   
   