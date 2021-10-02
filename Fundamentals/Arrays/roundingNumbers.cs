﻿using System;
using System.Linq;

namespace roundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==0)
                {
                    numbers[i] = 0;
                }
                double number = numbers[i];
                int roundedNum = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNum}");
            }
        }
    }
}