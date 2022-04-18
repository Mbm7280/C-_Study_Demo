using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：替换字符串
namespace Demo28
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Echo";
            String name2 = name.Replace("E","EE");
            Console.WriteLine(name2);
            Console.ReadLine();
        }
    }
}
