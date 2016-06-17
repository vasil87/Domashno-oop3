

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
            
            int seconds = int.Parse(Console.ReadLine());
            string mesage = Console.ReadLine();
            Timer x = new Timer(mesage);
            x.VasilsEvent += x.Print;
            x.VasilsEvent += x.Times;
            x.TimerPrint(seconds);
            

        }

        
    }
}
