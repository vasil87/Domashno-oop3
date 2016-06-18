

namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //public delegate void TestDelegate(string x);

    public class StartUp
    {
        public static void Main()
        {
            TestDelegate a;
            Console.WriteLine("Please Enter In how many seconds to refresh the clock");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Name here");
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
