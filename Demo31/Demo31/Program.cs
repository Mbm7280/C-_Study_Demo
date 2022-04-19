using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 数组
namespace Demo31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 0, 1, 2, 3, 4 };
            //int[] arr = new int[] { 0, 1, 2, 3, 4 };
            //int[] arr = { 0, 1, 2, 3, 4 };
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
