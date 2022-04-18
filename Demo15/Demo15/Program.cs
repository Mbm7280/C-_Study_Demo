using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 类型转换——显式类型转换
namespace Demo15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 方法一：类型名）表达式            //int a = (int) 10.1;
            //double b = 10;
            //int c = (int)b;

            // 方法二：Convert.To类型名（表达式）       项目中常用
            //double a = 10;
            //int b = Convert.ToInt32(a);

            // 方法三：类型名.Parse（表达式）
            double a = 10;
            int b = int.Parse(a.ToString());

            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
