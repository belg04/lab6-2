using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtInputReal.Text, out double number))
            {
                lbQueqe.Items.Add(number);
                QueqeResult.Text = $"Вещественное число {number} добавлено в список.";
            }
            else
            {
                MessageBox.Show("введите корректное вещественное число.");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int negativeCount = 0;
            foreach (var item in lbQueqe.Items)
            {
                if (item is double db && db < 0)
                {
                    negativeCount++;
                }
            }
            QueqeResult.Text = $"Количество отрицательных чисел в списке: {negativeCount}";
        }

        public MainWindow()
        {
            InitializeComponent();





    
        }
    }


}