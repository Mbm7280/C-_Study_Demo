using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 字符串常用操作：格式化日期数据
//格 式 规 范 说 明
//d 简短日期格式（YYYY-MM-dd）
//D 完整日期格式（YYYY年MM月dd日）
//t 简短时间格式（hh:mm）
//T 完整时间格式（hh:mm:ss）
//f 简短的日期/时间格式（YYYY年MM月dd日 hh:mm）
//F 完整的日期/时间格式（YYYY年MM月dd日 hh:mm:ss）
//g 简短的可排序的日期/时间格式（YYYY-MM-dd hh:mm）
//G 完整的可排序的日期/时间格式（YYYY-MM-dd hh:mm:ss）   
//M或m 月/日格式（MM月dd日） 
//Y或y 年/月格式（YYYY年MM月） 
namespace Demo21
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            string strB = String.Format("{0:D}", dt);            Console.WriteLine(strB);
            Console.ReadLine();
        }
    }
}
