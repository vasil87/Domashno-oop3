

namespace Devisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class Devisible_by_7_and_3
    {
        public static void Main()

        {
            int[] number = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                number[i] = i;

            }

            var result=number.Where(x => x % 3 == 0 || x % 7 == 0);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\n\n");

            var result2 =
                (from item in number
                where (item % 3 == 0 || item % 7 == 0)
                select item).ToArray();


            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }



        }

    }
}
