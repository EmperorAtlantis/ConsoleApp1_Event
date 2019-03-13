using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace ConsoleApp1
{
    
    public class People
    {
        public event EventHandler ToEatEvent;

        public People()
        {
            ToEatEvent += CheckToEat;
            ToEatEvent.Invoke(this, null);
            HungreValue = 100;
            WriteLine(HungreValue);
            
        }
        public int HungreValue { get; set; }
        
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                WriteLine("运动~~~~~~~~~");
                HungreValue--;
                WriteLine(HungreValue);
                Thread.Sleep(1000);
            }
        }

        public void Eat()
        {
            if (this.HungreValue < 30)
            {
                WriteLine("吃饭~~~~~~~");
                HungreValue = 100;
                WriteLine(HungreValue);
                Thread.Sleep(3000);
            }
        }

        public void CheckToEat(object sender, EventArgs e)
        {
            Eat();
        }
    }
}
