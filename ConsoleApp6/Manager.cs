using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp6
{
    class Manager : Employee
    {
        int tonnage { get; set; }
        public Manager() { }
        public Manager(string _name,string _surname,int _p,int _tonnage) : base(_name, _surname, _p)
        {

            tonnage = _tonnage;
        }
        public override void K()
        {
            Write("Введите H: ");
            double h = double.Parse(ReadLine());
            if (tonnage > h)
            {
                double k = 1 + (h/100);
                double res = p * k;
                WriteLine($"Доход({p}) повышен в {k} раз и равен - {res}");
            }
            else
            {
                WriteLine("Объем продаж менеджера меньше, чем H,повышения з/п не будет.");
            }

        }

    }
}
