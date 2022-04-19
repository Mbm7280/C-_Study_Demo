using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

// Hashtable
namespace Demo33
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", "Echo");
            foreach (DictionaryEntry dic in hashtable) {
                Console.WriteLine(dic.Key + "\n" + dic.Value);
            }
            Console.ReadLine();
        }
    }
}
