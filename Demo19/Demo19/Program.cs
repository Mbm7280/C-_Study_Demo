using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：比较
namespace Demo19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 比较两个字符串的值
            String name = "Echo";
            String name2 = "Tom";
            Console.WriteLine(name == name2);
            Console.WriteLine(name.Equals(name2));
            

            // 比较两个字符串的值，如果是英文或汉字，则比较它们在字典中的位置
            Console.WriteLine(String.Compare(name,name2));
            Console.WriteLine(name.CompareTo(name2));

            Console.ReadLine();
        }
    }
}
