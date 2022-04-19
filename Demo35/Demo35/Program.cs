using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// struct 结构
// 构成和类相似
// 定义成员变量不能赋初值
namespace Demo35
{
    class Program
    {
        public struct StructStudent
        {
            public string Name;
            public int Age;
            public string Hobby;
            public int Popularity;
            public void SayHi() {
                Console.WriteLine("Hi");
            }
        }

        static void Main(string[] args)
        {
            StructStudent stu = new StructStudent();
            stu.Name = "Echo";
            stu.SayHi();
            Console.ReadLine();
        }
    }
}
