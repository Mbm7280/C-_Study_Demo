using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：截取字符串
namespace Demo22
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "echo@163.com";
            string name = email.Substring(0, email.IndexOf("@"));
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
