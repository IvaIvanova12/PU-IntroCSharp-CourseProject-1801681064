using System;
using System.Text;

namespace Task163Page100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int b = 0, c = 0, d = 0, p, q;

            for (int a = 2; a <= 20; a++)
            {
                b = a + 1;
                c = b + 1;
                d = c + 1;
                q = d + 1;
                p = -1 * q;

                for (int x = p; x <= q; x++)
                    for (int y = p; y <= q; y++)
                        for (int z = p; z <= q; z++)
                            if (a * x + b * y + c * z + d == 0) Console.WriteLine(x + " " + y + " " + z);

            }


        }
    }
}
