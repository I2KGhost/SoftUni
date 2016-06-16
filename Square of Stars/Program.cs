using System;


namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string spaces = new string(' ', n - 2);   // създава ни стринг с n-2 интервала
            string startingStars = new string('*', n);  //създава ни стринг с n звезди

            Console.WriteLine(startingStars);   // отпечатва първи ред

            for (int i = 1; i <= (n - 2); i++)   //отпечатва от втори до n-1 ред
            {
                Console.WriteLine("*" + spaces + "*");
            }
            Console.WriteLine(startingStars);   // отпечатва последния ред

        }
    }
}
