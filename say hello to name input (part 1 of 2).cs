
// 02. try to say hello with input aname and show popop MassageBox warning


namespace test_messagebox
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
            //MessageBox.Show("Hello " + txtName.Text);
            MessageBox.Show("Hello " + txtName.Text , "Popup" , MessageBoxButton.YesNo , MessageBoxImage.Warning);
        }
    }
}

