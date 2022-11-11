// See https://aka.ms/new-console-template for more information
using System;

namespace ReverseIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int x = Convert.ToInt32(Console.ReadLine());        
            int res = Reverse(x);
            Console.WriteLine($"Result: {res}");

        }

        //Use remainder(mod) technique
        static int Reverse(int x) {
            int rev = 0;
            int rem;

            while(x!=0)
            {
                rem = x%10; //get the remainder of x mod 10
                rev = rev*10 + rem; //add the value of remainder to previous value*10
                x/=10; //get the new x value by divide with 10
            }
            return rev; //return the reversed value      
        }

        //Use stack to reverse the input
        static int Reverse_2(int x)
        {
            string str = x.ToString();

            Stack<string> stack_str = new Stack<string>();
            foreach (char c in str)
            {
                stack_str.Push(c.ToString());
            }

            string rev = "";
            foreach (var item in stack_str)
            {
                rev += item;
            }
            return int.Parse(rev);

        }
    }    
}
