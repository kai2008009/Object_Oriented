using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的成员
{
    class Program
    {
        public string s; //公有成员
        private double d;//私有成员
        static void Main(string[] args)
        {
            Program po = new Program();
            //Program2 po = new Program2();
            po.s = "大傻";
            Console.WriteLine("{0}", po.s);
            Console.ReadKey();
        }
        public void f1()
        {
            s = "Welcone sixAge"; //允许访问自身成员
            d = 89.65;//允许访问自身成员
        }
    }
    class Program2 : Program//从Program派生类Program2
    {
        int x;//私有成员
        public void f2()
        {
            x = 100;//允许访问自身成员
            s = "hello word";//允许访问Program的公有成员，允许访问Program保护成员，不能访Program问私有成员
        }
    }
    class Program3
    {
        public void f3()
        {
            Program p = new Program();//声明类Program的实例p
            p.s = "访问Program的公有成员！";//允许访问Program的公有成员，不能访问Program的保护成员，不能访问Program的私有成员
        }
    }

}

