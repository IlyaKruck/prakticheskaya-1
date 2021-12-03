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
using Lib_5;

namespace Практическая_работа__1_Крючков_Илья
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
        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            Chisla.Text = null;
            Sum.Text = null;
            Kol.Text = null;
            K.Text = null;
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крючков Илья\n" + "Практическая работа №1\n" + "Вычислить сумму целых случайных чисел, распределенных в диапазоне от -7 до 3, пока эта сумма не превышает некоторого числа K. Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            int k, kol;
            k = Convert.ToInt32(K.Text);// ввод K
            if (k > 0) MessageBox.Show("Ошибка, введите отрицательное число");
            else
            {
                Class1.Sum(k, out kol, out string h2, out string h1);// применение функции
                Chisla.Text = h2;// вывод сгенерированных чисел
                Sum.Text = h1;// вывод суммы
                Kol.Text = Convert.ToString(kol);// вывод количесва чисел
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крючков Илья\n" + "Практическая работа №1\n" + "Вычислить сумму целых случайных чисел, распределенных в диапазоне от -7 до 3, пока эта сумма не превышает некоторого числа K. Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Chisla.Text = null;
            Sum.Text = null;
            Kol.Text = null;
            K.Text = null;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крючков Илья\n" + "Практическая работа №1\n" + "Вычислить сумму целых случайных чисел, распределенных в диапазоне от -7 до 3, пока эта сумма не превышает некоторого числа K. Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }
    }
}
