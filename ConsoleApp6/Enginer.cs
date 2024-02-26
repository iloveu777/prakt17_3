using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp6
{
    class Enginer : Employee
    {
        int projects { get; set; }
        public Enginer(string _name, string _surname, int _p, int _projects) : base(_name, _surname, _p)
        {
            projects = _projects;
        }
        public override void K()
        {
            double res = p * (4.8 * projects);
            WriteLine($"Доход({p}) повышен и равен - {res}");

        }
    }
}
