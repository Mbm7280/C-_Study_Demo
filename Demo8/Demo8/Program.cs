using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echo; // 引用 Echo 命名空间

/*
*   命名空间的使用
*/
namespace Demo8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建 A 类
            A a = new A();
            // 调用 A 类的方法
            a.printEcho();
        }
    }
}

// 定义一个命名空间
namespace Echo
{
    // 定义一个类
    class A
    {
        // 定义一个方法
        public void printEcho() {
            Console.WriteLine("Echo");
            Console.ReadLine();
        }
    }
}