﻿using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = decimal.Parse(Console.ReadLine());
                var b = decimal.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}