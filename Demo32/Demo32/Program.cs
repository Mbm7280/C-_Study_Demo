using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// ArrayList
namespace Demo32
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("A");
            foreach (String str in list) {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
