using System;
using System.Windows;
using Lib_4;

namespace Prakt7
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

        Fraction pair1 = new Fraction(0, 0, 0, 0),
            pair2 = new Fraction(0, 0, 0, 0);

        private void btnSavePair1_Click(object sender, RoutedEventArgs e) // Сохранить изменения в паре 1
        {
            if (Int32.TryParse(tbPair1First.Text, out int p1) && Int32.TryParse(tbPair1FirstFraction.Text, out int f1) &&
                Int32.TryParse(tbPair1Second.Text, out int p2) && Int32.TryParse(tbPair1SecondFraction.Text, out int f2))
                pair1 = new Fraction(p1, f1, p2, f2);
            else MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnSavePair2_Click(object sender, RoutedEventArgs e) // Сохранить изменения в паре 2
        {
            if (Int32.TryParse(tbPair2First.Text, out int p1) && Int32.TryParse(tbPair2FirstFraction.Text, out int f1) &&
                Int32.TryParse(tbPair2Second.Text, out int p2) && Int32.TryParse(tbPair2SecondFraction.Text, out int f2))
                pair2 = new Fraction(p1, f1, p2, f2);
            else MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnSavePairs_Click(object sender, RoutedEventArgs e) // Сохранить изменения в обеих парах
        {
            if (Int32.TryParse(tbPair1First.Text, out int p1) && Int32.TryParse(tbPair1FirstFraction.Text, out int pf1) &&
                Int32.TryParse(tbPair1Second.Text, out int p2) && Int32.TryParse(tbPair1SecondFraction.Text, out int pf2) &&
                Int32.TryParse(tbPair2First.Text, out int q1) && Int32.TryParse(tbPair2FirstFraction.Text, out int qf1) &&
                Int32.TryParse(tbPair2Second.Text, out int q2) && Int32.TryParse(tbPair2SecondFraction.Text, out int qf2))
            {
                pair1 = new Fraction(p1, pf1, p2, pf2);
                pair2 = new Fraction(q1, qf1, q2, qf2);
            }
            else MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnSum_Click(object sender, RoutedEventArgs e) // Сложить пары
        {
            Fraction result = Fraction.Sum(pair1, pair2);
            tbResult.Text = $"{result.P1},{result.F1}; {result.P2},{result.F2}";
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e) // О программе
        {
            MessageBox.Show("Разработчик: Антонишин Кирилл Сергеевич\n" +
                "Практическая работа №7\n" +
                "Использовать класс Pair (пара чисел). Определить класс-наследник Fraction с характеристиками: " +
                "целая часть числа и дробная часть числа. Определить операцию сложения двух денежных единиц.",
                "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e) // Выход
        {
            this.Close();
        }
    }
}
