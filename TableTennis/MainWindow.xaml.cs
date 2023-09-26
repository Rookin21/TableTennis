using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace TableTennis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd = new Random();

        public object ButtonPlayer { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Генерация сетки 1/8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generation(object sender, RoutedEventArgs e)
        {
            List<string> Players = (new string[] { "Инсаф", "Радис", "Юрий", "Рустем", "Алмас", "Александр Ф.", "Артем П.", "Сергей О.",
                                            "Даниил", "Линар", "Евгений Д.", "Раушан", "Ильнар", "Александр Д.", "Артур", "Фаиль" }).ToList(); //список

            ButtonPlayer1.Content = GetRandomElement(Players); 

            ButtonPlayer2.Content = GetRandomElement(Players); 

            ButtonPlayer3.Content = GetRandomElement(Players); 

            ButtonPlayer4.Content = GetRandomElement(Players); 

            ButtonPlayer5.Content = GetRandomElement(Players); 

            ButtonPlayer6.Content = GetRandomElement(Players); 

            ButtonPlayer7.Content = GetRandomElement(Players); 

            ButtonPlayer8.Content = GetRandomElement(Players); 

            ButtonPlayer9.Content = GetRandomElement(Players); 

            ButtonPlayer10.Content = GetRandomElement(Players); 

            ButtonPlayer11.Content = GetRandomElement(Players); 

            ButtonPlayer12.Content = GetRandomElement(Players); 

            ButtonPlayer13.Content = GetRandomElement(Players); 

            ButtonPlayer14.Content = GetRandomElement(Players); 

            ButtonPlayer15.Content = GetRandomElement(Players);

            ButtonPlayer16.Content = GetRandomElement(Players);
        }

        /// <summary>
        /// Рандомное игрок из списка
        /// </summary>
        /// <param name="Players"></param>
        /// <returns></returns>
        public string GetRandomElement(List<string> Players)
        {
            string RandomPlayer = Players[new Random().Next(Players.Count)];
            Players.Remove(RandomPlayer);
            return RandomPlayer;
        }

        private void ButtonPlayer1_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter1.Content = ButtonPlayer1.Content;
        }

        private void ButtonPlayer2_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));         
            PlayerQuarter1.Content = ButtonPlayer2.Content;
        }

        private void ButtonPlayer3_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter2.Content = ButtonPlayer3.Content;
        }

        private void ButtonPlayer4_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter2.Content = ButtonPlayer4.Content;
        }

        private void ButtonPlayer5_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer5.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer6.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter3.Content = ButtonPlayer5.Content;
        }

        private void ButtonPlayer6_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer5.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer6.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter3.Content = ButtonPlayer6.Content;
        }

        private void ButtonPlayer7_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer7.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer8.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter4.Content = ButtonPlayer7.Content;
        }

        private void ButtonPlayer8_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer7.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer8.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter4.Content = ButtonPlayer8.Content;
        }

        private void ButtonPlayer9_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer9.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer10.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter5.Content = ButtonPlayer9.Content;
        }

        private void ButtonPlayer10_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer9.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer10.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter5.Content = ButtonPlayer10.Content;
        }

        private void ButtonPlayer11_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer11.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer12.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter6.Content = ButtonPlayer11.Content;
        }

        private void ButtonPlayer12_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer11.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer12.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter6.Content = ButtonPlayer12.Content;
        }

        private void ButtonPlayer13_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer13.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer14.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter7.Content = ButtonPlayer13.Content;
        }

        private void ButtonPlayer14_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer13.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer14.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter7.Content = ButtonPlayer14.Content;
        }

        private void ButtonPlayer15_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer15.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer16.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter8.Content = ButtonPlayer15.Content;
        }

        private void ButtonPlayer16_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer15.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer16.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter8.Content = ButtonPlayer16.Content;
        }

        private void PlayerQuarter1_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerSemiFinal1.Content = PlayerQuarter1.Content;
        }

        private void PlayerQuarter2_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerSemiFinal1.Content = PlayerQuarter2.Content;
        }

        private void PlayerQuarter3_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerSemiFinal2.Content = PlayerQuarter3.Content;
        }

        private void PlayerQuarter4_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerSemiFinal2.Content = PlayerQuarter4.Content;
        }

        private void PlayerQuarter5_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter5.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter6.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerSemiFinal3.Content = PlayerQuarter5.Content;
        }

        private void PlayerQuarter6_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter5.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter6.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerSemiFinal3.Content = PlayerQuarter6.Content;
        }

        private void PlayerQuarter7_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter7.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerQuarter8.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerSemiFinal4.Content = PlayerQuarter7.Content;
        }

        private void PlayerQuarter8_Click(object sender, RoutedEventArgs e)
        {
            PlayerQuarter7.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerQuarter8.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerSemiFinal4.Content = PlayerQuarter8.Content;
        }

        private void PlayerSemiFinal1_Click(object sender, RoutedEventArgs e)
        {
            PlayerSemiFinal1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerSemiFinal2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            Finalist1.Content = PlayerSemiFinal1.Content;
            Finalist3.Content = PlayerSemiFinal2.Content;
        }

        private void PlayerSemiFinal2_Click(object sender, RoutedEventArgs e)
        {
            PlayerSemiFinal1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerSemiFinal2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            Finalist1.Content = PlayerSemiFinal2.Content;
            Finalist3.Content = PlayerSemiFinal1.Content;
        }

        private void PlayerSemiFinal3_Click(object sender, RoutedEventArgs e)
        {
            PlayerSemiFinal3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PlayerSemiFinal4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            Finalist2.Content = PlayerSemiFinal3.Content;
            Finalist4.Content = PlayerSemiFinal4.Content;
        }

        private void PlayerSemiFinal4_Click(object sender, RoutedEventArgs e)
        {
            PlayerSemiFinal3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PlayerSemiFinal4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            Finalist2.Content = PlayerSemiFinal4.Content;
            Finalist4.Content = PlayerSemiFinal3.Content;
        }

        private void Finalist1_Click(object sender, RoutedEventArgs e)
        {
            Finalist1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            Finalist2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
        }

        private void Finalist2_Click(object sender, RoutedEventArgs e)
        {
            Finalist1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            Finalist2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
        }

        private void Finalist3_Click(object sender, RoutedEventArgs e)
        {
            Finalist3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            Finalist4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
        }

        private void Finalist4_Click(object sender, RoutedEventArgs e)
        {
            Finalist3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            Finalist4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
        }
    }
}
