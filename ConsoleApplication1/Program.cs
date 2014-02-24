using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaleggs, dozeneggs, remaindereggs, chicken1 = 30, chicken2 = 14, chicken3 = 2, chicken4 = 17;
            totaleggs = chicken1 + chicken2 + chicken3 + chicken4;
            dozeneggs = totaleggs / 12;
            remaindereggs = totaleggs % 12;
            Console.WriteLine("all four chickens have produced a total of {0} dozen and {1} eggs", dozeneggs, remaindereggs)
        }
    }
}
