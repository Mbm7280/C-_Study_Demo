using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：删除字符串
namespace Demo26
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "echo";
            string sname = name.Remove(0, 1);
            Console.WriteLine(sname);
            Console.ReadLine();
        }
    }
}
