using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i ,o;
            
            Console.Write("Ведите вес");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведите Рост");
            o = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш вес  "+i+"Ваш рост  "+o);
            Console.ReadLine();
        }
    }
}
