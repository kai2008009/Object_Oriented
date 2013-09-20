using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO.NET
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt";
            if (ofd.ShowDialog() != true)
            {
                return;
            }
            string filename = ofd.FileName;

            IEnumerable<string> lines = File.ReadLines(filename);


        }

        //插入数据
        //SqlConnection建立和数据库连接对象
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //using(类型 d　=　new 类型)释放资源
            using (SqlConnection conn = new SqlConnection(
                "Data Source=.;Initial Catalog=test;User ID=sa;Password=123456"))
            {
                //打开连接
                conn.Open(); 
                //通过连接创建一个向数据库发命令（Command）的对象SqlCommand
                using (SqlCommand cmd =conn.CreateCommand())
                {
                    //CommandText为要执行的sql语句
                    cmd.CommandText = "Insert into custome(name,age)values('张思思',18)";
                    //执行
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("插入数据,执行成功!");
        }
    }
}
