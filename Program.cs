using System;

namespace Random

{
    class Program
    {
        static void Main(string[]args)
        {
            //string name;
           // string city;
            sbyte age;
            int pin;
            int house_number;
 
            
            Console.WriteLine("Enter your name\n");
           var name = Console.ReadLine();
 
            Console.WriteLine("Enter Your City\n");
           var  city = Console.ReadLine();
 
            
            Console.WriteLine("Enter your age\n");
           age = sbyte.Parse(Console.ReadLine());

            
            
 
            Console.WriteLine("Enter your pin\n");
           pin = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your house number?\n");
            house_number = Int32.Parse(Console.ReadLine());
 
            
            Console.WriteLine("==============");
            Console.WriteLine("Your Complete Address:");
            Console.WriteLine("============\n");
 
            Console.WriteLine($"Name {name} ");
            Console.WriteLine($"City {city} ");
            Console.WriteLine($"Age {age}");
            Console.WriteLine($"Pin  {pin}");
            Console.WriteLine($"House Number {house_number} ");
            Console.WriteLine("===============");
 
            Console.ReadLine();

        }
    }
}
