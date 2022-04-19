using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//访问修饰符 访问权限    访问级别
//public 不受任何限制 最高
//private 只有在声明类的内部可以使用 最低
//protected 受保护，在类及派生类（子类）中访问
//internal 在所在类（可以是分部类的不同部分）中访问
namespace Demo34
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Name = "123";
            Console.WriteLine(b.Name);
            Console.ReadLine();
        }
    }

    class Book
    {
        private int id;
        private string name;
        private double price;
        //设置图书编号属性
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //设置图书名称属性
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //设置图书价格属性
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }

}
