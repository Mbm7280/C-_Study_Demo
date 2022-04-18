using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 类型转换——隐式类型转换
// 两种类型兼容//      int 和 double 兼容//      目标类型大于源类型
namespace Demo14
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstAvg = 81.29;
            double secondAvg;
            int rise = 2;
            secondAvg = firstAvg + rise;
            Console.WriteLine("第二次平均分是：" + secondAvg);            Console.ReadLine();        }
    }
}
