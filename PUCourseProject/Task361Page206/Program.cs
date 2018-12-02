using System;
using System.Text;

namespace Task361Page206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Въведете дума: ");
            string S = Console.ReadLine();
            string S2 = S.Replace("A*A", "sqr(A)");
            Console.WriteLine(S2);
        }
    }
}
