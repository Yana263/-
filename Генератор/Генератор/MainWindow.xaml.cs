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

namespace Генератор
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
        public string GeneratePass()
        {
            string iPass = ""; 
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" }; 
            Random rnd = new Random(); 
            for (int i = 0; i < 30; i = i + 1)
            {
                iPass = iPass + arr[rnd.Next(0, 57)];
            }
            return iPass;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            textBox1.Text = GeneratePass();

        }
        

        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

