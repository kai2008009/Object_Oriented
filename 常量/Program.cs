using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常量
{
    class Program
    {
        //常量不可修改
        public const string name = "李四";
        public const int i = 1;
        public const int j = 2;

        static void Main(string[] args)
        {
            //const string name = "张三";
            const int i = 3;
            
            Console.WriteLine("{0}",name);

            age();
            
            Console.WriteLine("{0}-{1}-{2}",i,j,i+j);
            Console.ReadKey();
        }

        static public void age()
        {
            Console.WriteLine("{0}",i);
        }

    }
}
