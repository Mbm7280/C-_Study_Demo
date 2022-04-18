using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：复制字符串
namespace Demo27
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Echo";
            String name2 = string.Copy(name);
            Console.WriteLine(name2);
            Console.ReadLine();
        }
    }
}
