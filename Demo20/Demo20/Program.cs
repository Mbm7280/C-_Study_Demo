using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：格式化字符串
namespace Demo20
{
    class Program
    {

        static void Main(string[] args)
        {
            string myString = string.Format("{0} 乘以 {1} 等于 {2} ", 2, 3, 2 * 3);            Console.WriteLine(myString);            Console.ReadLine();        }
    }
}
