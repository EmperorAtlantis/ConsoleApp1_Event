using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    public class People1
    {


        public delegate void EventHandler();
        public event EventHandler ToEatEvent;

        public int HungreValue { get; set; }

        public People1()
        {
            ToEatEvent += new EventHandler(ToEat);
            
            HungreValue = 100;
        }


        public void Run()
        {
            WriteLine("运动~~~~~~~~~");
            while (HungreValue >= 30)
            {
                //ToEatEvent();
                ToEatEvent?.Invoke();
                HungreValue--;
                WriteLine(HungreValue);
                Thread.Sleep(100);
            }


        }

        public void ToEat()
        {
            if (HungreValue <= 30)
            {
                WriteLine("吃饭~~~~~~~");
                Thread.Sleep(3000);
                HungreValue = 100;
                WriteLine(HungreValue);
            }
        }
    }
}
