using System;
using static System.Console;

namespace Painting_Estimate
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, estimate;

            Write("Enter the length of the house in feet:  ");
            length = int.Parse(ReadLine());
            Write("Enter the width of the house in feet:  ");
            width = Convert.ToInt16(ReadLine());
            WriteLine("The cost for painting your room  is {0}", Computecost(length, width).ToString("C"));

        }
             
        private static int Computecost(int length, int width)
        {
           
           
            const int PRICE = 6;
            int cost = 0;
            const int HEIGHT = 9;
            cost = ((length * HEIGHT * 2) + (width * HEIGHT * 2)) * PRICE;



            return cost;


        }
    }
}
