using System;


namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                string stars = new string('*', i);
                Console.WriteLine(stars);
            }
        }
    }
}