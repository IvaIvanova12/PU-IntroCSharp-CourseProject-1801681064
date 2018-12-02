using System;
using System.Text;

namespace Task53Page42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете x");
            int x = int.Parse(Console.ReadLine());
            int sgnx = 0;


            if (x < 0) sgnx = -1;
            else if (x == 0) sgnx = 0;
            else sgnx = 1;

            Console.WriteLine(sgnx);
        }
    }
}
