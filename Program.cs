using System;

namespace Random

{
    class Program
    {
        static void Main(string[]args)
        {
         int opt, num1, num2;
         decimal result;

         System.Console.WriteLine("\n\tMenu");
         System.Console.WriteLine("\n Press 1 for addition");
         System.Console.WriteLine("\n Press 2 for subtraction");
         System.Console.WriteLine("\n Press 3 for multiplication");
         System.Console.WriteLine("\n Press 4 for division");

         System.Console.WriteLine("\n Enter your first number?");
         num1 = Convert.ToInt32(Console.ReadLine());

         System.Console.WriteLine("\n Enter your second number?");
         num2 = Convert.ToInt32(Console.ReadLine()); 

         System.Console.WriteLine("Enter your options");
         opt = Convert.ToInt32(Console.ReadLine());
         
         if(opt == 1)
         {
             result = num1 + num2;
             System.Console.WriteLine($"The total of both numbers is {result}");
         }
        else if(opt ==2)
        {
            result = num1 - num2;
            System.Console.WriteLine($"The answer is {result} ");
        }
        else if(opt ==3)
        {
            result = num1 * num2;
            System.Console.WriteLine($"The answer of both numbers is {result}");
        }
        else if(opt == 4)
        {
           result =(decimal)(num1)/(decimal)(num2);
           System.Console.WriteLine($"The answer is {result}", num1/num2,result); 
        }
        else
        {
            System.Console.WriteLine("Invalid option, see menu");
        }

         Console.ReadLine();
        }
    }
}
