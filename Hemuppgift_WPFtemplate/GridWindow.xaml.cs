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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button.Content = $"Row {rowtext.Text}, Column {columntext.Text}";

            button.Background = Brushes.LightGreen;
            Grid.SetColumn(button, int.Parse(columntext.Text));
            Grid.SetRow(button, int.Parse(rowtext.Text));

            GridCell.Children.Add(button);
        }
    }
}
