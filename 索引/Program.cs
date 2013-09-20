using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1[1] = "123";
            Console.WriteLine(p1[1] + p1[2]);

            Console.WriteLine(p1["tom是",3,8]);
           
            Console.ReadKey();
        }
    }
    class Person
    {
        private string FristName = "大毛";
        private string SecondnName = "二毛";

        public string this[string name, int x, int y]
        {
            get
            {
                return name + x + y;
            }
        }

        public string this[int index]
        {
            set
            {
                if (index == 1)
                {
                    FristName = value;
                }
                else if (index == 2)
                {
                    SecondnName = value;
                }
                else
                {
                    try
                    {
                        throw new Exception("错误!!!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message, ex.StackTrace);
                    }
                }
            }
            get
            {
                if (index == 1)
                {
                    return FristName;
                }
                else if (index == 2)
                {
                    return SecondnName;
                }
                else
                {
                    throw new Exception("错误!!!");
                }
            }
        }
    }
}
