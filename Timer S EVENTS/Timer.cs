
namespace Timer
{ 
    using System;
    using System.Threading;
    public delegate void TimerEventHandler(object sender,EventArgs e);
    public  class Timer
    {
        public string Mesage { get; set; }
        public event TimerEventHandler VasilsEvent;

        public Timer(string x)
        {
            this.Mesage = x;
        }

        public void Print(object sender,EventArgs e)
        {   
           
             Console.WriteLine(this.Mesage);
             
        }

        public void TimerPrint(int seconds)
        {

            while (true)
            {
                Thread.Sleep(seconds * 1000);
                this.ProverkaZaSLushateli();
            }
        
        }

        public void ProverkaZaSLushateli()
        {
            if (this.VasilsEvent != null)
            {
                this.VasilsEvent(this, EventArgs.Empty);
            }
        }

        public void Times(object sender, EventArgs e)
        {
           // Console.Clear();
            //Console.WriteLine("Hello {0},the time is :",this.Mesage);
            Console.WriteLine(DateTime.Now);
        }
    }
}
