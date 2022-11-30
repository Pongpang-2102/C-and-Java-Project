using System;
using System.Collections.Generic;
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

namespace _18_Oct_22_Academy01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int time;

            // ถ้าออยากป้องกันการ error อาจ try catch ทั้งก้อนไปเลยก็ได้
            try
            {
                time = Convert.ToInt32(txtTime.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Time is not a number");
                txtTime.Focus();
                return;
            }

            if (time < 0 || time > 23)
            {
                MessageBox.Show("Incorrect !! Time should be between 0 - 23");
                return;
            }
            else
            {
                MessageBox.Show("Time is OK"); // ถ้าอันนี้ OK มันจะไปรัน code ข้างล่าง แต่ถ้ามี return มันจะไม่ทำข้างล่างต่อ
            }
            if (time < 10)
            {
                MessageBox.Show("Good Morning");
                return;  //ถ้าใช้ else if มันถูกบังคับให้วิ่งไปข้างล่างอยู่แล้ว ยังไงก็ไปถึงบรรทัดสุดท้าย -- > เอา return ออกได้
            }
            else if (time <= 19)
            {
                MessageBox.Show("Good Day");
                return;  //ถ้าใช้ else if มันถูกบังคับให้วิ่งไปข้างล่างอยู่แล้ว ยังไงก็ไปถึงบรรทัดสุดท้าย -- > เอา return ออกได้
            }

            else     
            {
                MessageBox.Show("Good Evening");
                return;  //ถ้าใช้ else if มันถูกบังคับให้วิ่งไปข้างล่างอยู่แล้ว ยังไงก็ไปถึงบรรทัดสุดท้าย -- > เอา return ออกได้
            }

        }
        
    }
}

