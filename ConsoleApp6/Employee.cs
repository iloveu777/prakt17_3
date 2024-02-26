using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp6
{
  public  class Employee
    {
        string name { get; set; }
        string surname { get; set; }
       public int p { get; set; }
        public Employee() { }
        public Employee(string _name, string _surname, int _p)
        {
            this.name = _name;
            this.surname = _surname;
            this.p = _p;
        
        }

        

        public virtual void Print()
        {
            WriteLine($"Имя: {name}, фамилия: {surname}, доход: {p}");

        }
        public virtual void K()
        {
            Write($"Введите коэффицент повешения зп: ");
            double k = int.Parse(ReadLine());
            double res = k * p;
            WriteLine($"Доход({p}) повышен в {k} раз и равен - {res}");        
        }
    }
}
