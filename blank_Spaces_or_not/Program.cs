using System;

namespace blank_Spaces_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter an number: ");
            number = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine(number + " " + number + " " + number +" " + number);
            Console.WriteLine(number + "" + number + "" + number + "" + number);
            Console.WriteLine(number + " " + number + " " + number + " " + number);
            Console.WriteLine(number + "" + number + "" + number + "" + number);
        }
    }
}
