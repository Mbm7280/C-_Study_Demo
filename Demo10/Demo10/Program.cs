using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 引用类型
namespace Demo10
{
    class Program
    {
        class Student {
            public int age;
        }

        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.age = 18;
            Console.WriteLine(stu.age);
            Console.ReadLine();
        }
    }
}
