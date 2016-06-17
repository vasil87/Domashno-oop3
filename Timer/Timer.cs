
namespace Timer
{ 
    using System;
    using System.Threading;
    public delegate void TestDelegate(string x);
    public  class Timer
    {
        public static void Print(string message)
        {   
           
             Console.WriteLine(message);
             
        }

       

        public static void TimerPrint(TestDelegate h,int seconds,string b)
        {

            while (true)
            {
                Thread.Sleep(seconds * 1000);
                h(b);
            }
        
        }



}
}
