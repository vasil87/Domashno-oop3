

namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            string[] vhod = new string[150];


            for (int i = 0; i < 150; i++)
            {
                Random top = new Random(i*i+i*i*i);
               
                vhod[i] = new string((char)top.Next(1, 99), top.Next(5,105));


            }

            var result = vhod.Min(x => x.Length);
            int count = 0;
            foreach (var item in vhod)
            {
                if (count % 7 == 6)
                { Console.WriteLine();
                    count = 0;
                 }
                Console.Write(item.Length + " ");
                count++;
            }

            Console.WriteLine();

            Console.WriteLine(result);

        }
    }
}
