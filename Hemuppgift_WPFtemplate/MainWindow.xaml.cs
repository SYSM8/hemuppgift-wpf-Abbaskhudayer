using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            new GridWindow().Show();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            new StackPanelWindow().Show();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            new WrapPanelWindow().Show();
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            new DockPanelWindow().Show();
        }
    }
}