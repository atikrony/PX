using System;
using System.Collections.Generic;



namespace PracticeStack0
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            Console.WriteLine("Inserted numbers:");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("poped number:");

           
            numbers.Pop();
               
           foreach (var number in numbers)
            {
               Console.WriteLine(number);
            }

        }
    }
}
