using _31_03_2022_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_03_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool toContinue = true;
            Console.WriteLine("----------------\n1 - Square\n2 - Rectangular\n0 - Quit\n----------------");
        Start: Console.Write("Input: ");
            int input = Convert.ToInt32(Console.ReadLine());
            while (toContinue)
            {
                switch (input)
                {
                    case 1:
                        Console.Write("\nSide of the Square: ");
                        int side = Convert.ToInt32(Console.ReadLine());
                        Square sqr = new Square(side);
                        Console.WriteLine($"Area of The Square: {sqr.CalculateArea()}\n");
                        goto Start;
                        break;
                    case 2:
                        Console.Write("\nWidth of the Rectangular: ");
                        int width = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Length of the Rectangular: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Rectangular rct = new Rectangular(width, length);
                        Console.WriteLine($"Area of The Rectangular: {rct.CalculateArea()}\n");
                        goto Start;
                        break;
                    case 0:
                        Console.WriteLine("\nYou have ended the program! Thank you for coming!");
                        toContinue = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input! Try again!\n");
                        goto Start;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
