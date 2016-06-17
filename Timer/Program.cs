

namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //public delegate void TestDelegate(string x);

    public class Program
    {
        public static void Main()
        {
            TestDelegate a;
            int seconds = int.Parse(Console.ReadLine());
            string mesage = Console.ReadLine();
            a = Timer.Print;
            a += Times; 
            Timer.TimerPrint(a, 1, mesage);

        }

        public static void Times (string y)
            {
              Console.Clear();
              Console.WriteLine("Hello {0},the time is :", y);
              Console.WriteLine(DateTime.Now);
            }
    }
}
