using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 流程控制语句：Goto的使用
namespace Demo30
{
    class Program
    {
        static void Main(string[] args)
        {
            goto echo;
            Console.WriteLine("1");
            echo: Console.WriteLine("2");
            Console.ReadLine();
        }
    }
}
