using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 变量的定义以及基本数据类型
// 首字母以：字母或者下划线‘_’开头// 其余部分：1、数字\字母\下划线 组成
namespace Demo9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数据类型   变量名  =  数值；
            // 命名注意驼峰命名法规则
            // 整数
            int age = 18;
            // 字符
            String name = "Echo";
            // 浮点
            double height = 187.8;
            // 布尔
            bool guess = false;
            // char
            char sex = '男';
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(height);
            Console.WriteLine(guess);
            Console.WriteLine(sex);
            Console.ReadLine();
        }
    }
}
