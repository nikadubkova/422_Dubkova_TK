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

namespace ExamCalculator
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int score1 = int.Parse(Score1TextBox.Text);
                int score2 = int.Parse(Score2TextBox.Text);
                int score3 = int.Parse(Score3TextBox.Text);
                int score4 = int.Parse(Score4TextBox.Text);

                // Проверка на валидность введенных баллов
                if (!IsValidScore(score1, 10) || !IsValidScore(score2, 50) ||
                    !IsValidScore(score3, 30) || !IsValidScore(score4, 10))
                {
                    MessageBox.Show("Баллы должны быть в диапазоне от 0 до максимального значения для каждого задания.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                int totalScore = score1 + score2 + score3 + score4;
                string grade = GetGrade(totalScore);

                ResultLabel.Content = $"Общая сумма баллов: {totalScore}\nОценка: {grade}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целые числа в поля баллов.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool IsValidScore(int score, int maxScore)
        {
            return score >= 0 && score <= maxScore;
        }

        public string GetGrade(int totalScore)
        {
            if (totalScore >= 70 && totalScore <= 100)
            {
                return "5 (отлично)";
            }
            else if (totalScore >= 40 && totalScore <= 69)
            {
                return "4 (хорошо)";
            }
            else if (totalScore >= 20 && totalScore <= 39)
            {
                return "3 (удовлетворительно)";
            }
            else
            {
                return "2 (неудовлетворительно)";
            }
        }
    }
}
