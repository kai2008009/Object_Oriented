using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This关键字
{
    public class employee
    {
        public string name;
        public decimal salary;

        //构造函数
        public employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        //显示员工姓名及薪水
        public void DiaplayEmployee()
        {
            Console.WriteLine("姓名：{0}", name);
            Console.WriteLine("薪水：{0}元", salary);
            Console.WriteLine("个人所得税：{0}", Tax.CalcTax(this));
        }
    }

    public class Tax
    {
        public static decimal CalcTax(employee e)
        {
            return (0.14m * (e.salary - 800.0m));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee("矢车菊", 4568.6m);
            e.DiaplayEmployee();
            Console.ReadKey();
        }
    }
}
