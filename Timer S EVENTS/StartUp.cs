

namespace Timer
{
    using System;
   

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter In how many seconds to refresh the clock");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Name here");
            string mesage = Console.ReadLine();
            Timer x = new Timer(mesage);   
            x.VasilsEvent += x.Print;
            x.VasilsEvent += x.Times;
            x.TimerPrint(seconds);
            

        }

        
    }
}
