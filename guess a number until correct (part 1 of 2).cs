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

namespace _18_Oct_22_Academy04_guess_Number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ครั้งที่ทาย (Number of time guessed) // ไว้ใต้ Main Window ได้ แต่ไว้ตรงนี้จะเห็นชัดเจนดีเวลาคนอื่นมาอ่าน code
        int guess = 1;

        // คำตอบ (Answer) // ไว้ใต้ Main Window ได้ แต่ไว้ตรงนี้จะเห็นชัดเจนดีเวลาคนอื่นมาอ่าน code
        int answer;

        public MainWindow() // constructor : This part will be called prior other part (Program Prep)
                              //เวลาเค้าสร้างออบเจ็ค  ตัวนี้จะถูกเรียกใช้งานก่อน
        {
            InitializeComponent(); // gen UI ต่าง ๆ 

            // setup ค่า
            guess = 1;
            answer = new Random().Next(1, 101);
        }

        private void Guess_button_Click(object sender, RoutedEventArgs e)
        {
            int number;
            try
            {
                number = Convert.ToInt32(txtNumber.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Number !");
                txtNumber.Focus();
                return;
            }

            if (number < answer)
            {
                MessageBox.Show($"{number} is too little !!!");
                guess++;
                lblGuess.Content = guess;
            }
            else if (number > answer)
            {
                MessageBox.Show($"{number} is too much !!!");
                guess++;
                lblGuess.Content = guess;
            }
            else
            {
                MessageBox.Show($"{number} is correct !!! You have guessed {guess} times");
                guess = 1;
                lblGuess.Content = guess;
                answer = new Random().Next(1, 101);

            }

        }
    }
}
