using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tao_lop_thu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog bull = new Dog(40, 0.5, "gruuuu", "nhanh nhen", true);
            bull.GetInfo();
            bull.Move();
            bull.MakeSound();
            Console.ReadLine();
        }
    }
}
