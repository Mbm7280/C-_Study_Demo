using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 类型转换——装箱和拆箱
namespace Demo12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2022;								//声明一个int类型变量i，并初始化为2022
            object obj = i;							//声明一个object类型obj，其初始化值为i
            Console.WriteLine("1、i的值为{0}，装箱之后的对象为{1}", i, obj);
            i = 927;									//重新将I赋值为927
            Console.WriteLine("2、i的值为{0}，装箱之后的对象为{1}", i, obj);
            Console.ReadLine();
        }
    }
}
