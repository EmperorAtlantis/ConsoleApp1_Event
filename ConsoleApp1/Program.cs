using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private delegate string Method();
        static void Main(string[] args)
        {

            //    string s1 = "a";
            //    string c1 = "a";
            //    string s2 = "b";

            //    int i = 1;
            //    int x = 0;
            //    int y = 0;

            //    Console.WriteLine("s1:" + s1.GetHashCode());
            //    Console.WriteLine("s2:" + s2.GetHashCode());
            //    Console.WriteLine(RuntimeHelpers.GetHashCode(s1));
            //    Console.WriteLine(RuntimeHelpers.GetHashCode(c1));
            //    Console.WriteLine(RuntimeHelpers.GetHashCode(s2));
            //    Changes(ref s1, ref s2);
            //    Console.WriteLine("s1:" + s1.GetHashCode());
            //    Console.WriteLine("s2:" + s2.GetHashCode());
            //    Console.WriteLine(RuntimeHelpers.GetHashCode(s1));
            //    Console.WriteLine(RuntimeHelpers.GetHashCode(s2));
            //    Change(ref i, out x, out y);
            //    Console.WriteLine(x.GetType().ToString() + ":" + x);


            //Users users = new Users(0, "a");



            //Method method = new Method(users.ToString);

            People1 p = new People1();
            p.Run();
            //users++;
            //Console.Write(JsonConvert.SerializeObject(users));
            Console.Write("");
            Console.Read();
        }

        //public static void Change(ref int i, out int x, out int y)
        //{
        //    x = 2; y = 3;
        //    i = 3;
        //}

        //public static void Changes(ref string s1, ref string s2)
        //{
        //    s1 = s1 + s2;
        //}
    }
}
