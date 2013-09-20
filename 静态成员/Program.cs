using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态成员
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.TotalCout = 90;
            
            Console.WriteLine(Person.TotalCout);

            DoIt();

            Dog dog = new Dog();
            dog.DogA();

            Person p1 = new Person();
            p1.Name = "123";
            p1.name();
            
            Person.Count();

            Console.ReadKey();
        }
        public static void DoIt()
        {
            Console.WriteLine("bbbbbbbbb");
            Console.WriteLine("全局变量:{0}", Person.TotalCout);
        }
    }
    public class Person
    {
        //静态成员static
        public static int TotalCout;

        //非静态成员
        public string Name;

        //静态方法
        public static void Count()
        {
            //静态方法能调用静态成员
            Console.WriteLine("总数{0}",TotalCout);
        }

        //非静态方法
        public void name()
        {
            //非静态方法能调用所有成员
            Console.WriteLine("我叫{0},地球人数是{1}",Name,TotalCout);
        }
    }

    //类
    public class Dog
    {
        //方法
        public void DogA()
        {
            Console.WriteLine("汪汪{0}", Person.TotalCout);
        }
    }
}
