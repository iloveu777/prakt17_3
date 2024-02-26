using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Manager manager = new Manager("asd", "asd", 1000, 10);
            manager.K();*/
            /*
            Enginer n1 = new Enginer("asd", "asd", 1000, 10);
            n1.K();
            */
            Manager[] mmm = new Manager[4];
            for (int i = 0; i < mmm.Length; i++)
            {
                string asd = "asd";

                mmm[i] = new Manager(asd,asd,1000,5);
            }
            foreach (Manager m in mmm)
            {

                m.Print();

            }
            ReadKey();
        }
    }
}
