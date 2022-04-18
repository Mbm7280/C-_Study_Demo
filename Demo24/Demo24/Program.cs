using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：插入字符串
namespace Demo24
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "echo";
            string email = name.Insert(4, "@163.com");
            Console.WriteLine(email);
            Console.ReadLine();
        }
    }
}
