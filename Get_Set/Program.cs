using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    namespace Get_Set属性的用法
    {
        public class Student
        {
            private string stuCollege = "清华大学";//学校名称不可修改
            private string stuName = "阿会楠";
            private int stuAge = 22;

            //姓名可读、可写
            public string studentName
            {
                get { return stuName; }
                set { stuName = value; }
            }

            //年龄可读、可写
            public int studentAge
            {
                get { return stuAge; }
                set { stuAge = value; }
            }

            //学校名称可读、不可写
            public string studentCollege
            {
                get { return stuCollege; }
            }

            public string studentInfo
            {
                get { return "学校：" + stuCollege + "\n名字：" + stuName + "\n岁数：" + stuAge; }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student stu = new Student();
                Console.Write(stu.studentCollege + "\n");
                stu.studentAge = 25;
                Console.Write(stu.studentInfo);
                Console.ReadKey();
            }
        }
    }
}
