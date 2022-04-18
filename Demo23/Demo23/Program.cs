using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：分割字符串
namespace Demo23
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Echo，C#编程词典，珍藏版";
            string[] strs = str.Split(new char[] { '，' });            Console.WriteLine(strs[0]);
            Console.ReadLine();
        }
    }
}
