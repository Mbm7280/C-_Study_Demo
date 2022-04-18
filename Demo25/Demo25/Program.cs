using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：填充字符串
namespace Demo25
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "*^__^*";
            // 左填充
            string str2 = str1.PadLeft(7, '(');
            // 右填充
            string str3 = str2.PadRight(8, ')');            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}
