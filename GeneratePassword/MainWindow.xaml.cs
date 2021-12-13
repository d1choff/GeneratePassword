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

namespace GeneratePassword
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string GetPass()
        {
            Random rnd = new Random();
            string[] abc = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
            int Numbers = Convert.ToInt32(tbNumPass.Text);
            string result = "";
            for (int i = 0; i < Numbers; i++)
            { 
                result += abc[rnd.Next(abc.Length)];
            }
            return result;
        }

        private void btnGenPassword_Click(object sender, RoutedEventArgs e)
        {
            tbOutPass.Text = GetPass();
        }
    }
}
