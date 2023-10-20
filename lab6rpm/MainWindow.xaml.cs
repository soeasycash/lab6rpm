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

namespace lab6rpm
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
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Получаем текст из Memo и разделяем его на массив вещественных чисел
            string[] inputNumbers = MemoTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Проверка на пустой ввод
            if (inputNumbers.Length == 0)
            {
                MessageBox.Show("Введите вещественные числа в Memo.", "Ошибка");
                return;
            }

            // Преобразование строковых чисел в массив вещественных чисел
            double[] numbers = new double[inputNumbers.Length];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (double.TryParse(inputNumbers[i], out double number))
                {
                    numbers[i] = number;
                }
                else
                {
                    MessageBox.Show($"Ошибка преобразования числа '{inputNumbers[i]}' в вещественное число.", "Ошибка");
                    return;
                }
            }

            // Находим максимальное число в массиве
            double maxNumber = numbers.Max();

            // Отображаем результат
            MaxNumberLabel.Content = $"Наибольший элемент массива: {maxNumber}";
        }
    }
}
