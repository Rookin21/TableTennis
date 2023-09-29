using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
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

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Получение радномного игрока из списка
        /// </summary>
        /// <param name="Players"></param>
        /// <returns></returns>
        private string GetRandomElement(List<string> Players)
        {
            string RandomPlayer = Players[new Random().Next(Players.Count)];
            Players.Remove(RandomPlayer);
            return RandomPlayer;
        }

        /// <summary>
        /// Генерация одиночной турнирной сетки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SingleGameGeneration(object sender, RoutedEventArgs e)
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

        #region Кнопки прохождения игроков по одиночной турнирной сетке

        #region Кнопки 1/8

        private void ButtonPlayer1_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter1.Content = ButtonPlayer1.Content;
        }

        private void ButtonPlayer2_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter1.Content = ButtonPlayer2.Content;
        }

        private void ButtonPlayer3_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter2.Content = ButtonPlayer3.Content;
        }

        private void ButtonPlayer4_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter2.Content = ButtonPlayer4.Content;
        }

        private void ButtonPlayer5_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer5.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer6.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter3.Content = ButtonPlayer5.Content;
        }

        private void ButtonPlayer6_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer5.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer6.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter3.Content = ButtonPlayer6.Content;
        }

        private void ButtonPlayer7_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer7.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer8.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter4.Content = ButtonPlayer7.Content;
        }

        private void ButtonPlayer8_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer7.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer8.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter4.Content = ButtonPlayer8.Content;
        }

        private void ButtonPlayer9_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer9.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer10.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter5.Content = ButtonPlayer9.Content;
        }

        private void ButtonPlayer10_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer9.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer10.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter5.Content = ButtonPlayer10.Content;
        }

        private void ButtonPlayer11_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer11.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer12.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter6.Content = ButtonPlayer11.Content;
        }

        private void ButtonPlayer12_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer11.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer12.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter6.Content = ButtonPlayer12.Content;
        }

        private void ButtonPlayer13_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer13.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer14.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter7.Content = ButtonPlayer13.Content;
        }

        private void ButtonPlayer14_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer13.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer14.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter7.Content = ButtonPlayer14.Content;
        }

        private void ButtonPlayer15_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer15.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayer16.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter8.Content = ButtonPlayer15.Content;
        }

        private void ButtonPlayer16_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayer15.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayer16.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter8.Content = ButtonPlayer16.Content;
        }

        #endregion

        #region Кнопки 1/4

        private void PlayerQuarter1_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerSemiFinal1.Content = ButtonPlayerQuarter1.Content;
        }

        private void PlayerQuarter2_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerSemiFinal1.Content = ButtonPlayerQuarter2.Content;
        }

        private void PlayerQuarter3_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerSemiFinal2.Content = ButtonPlayerQuarter3.Content;
        }

        private void PlayerQuarter4_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerSemiFinal2.Content = ButtonPlayerQuarter4.Content;
        }

        private void PlayerQuarter5_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter5.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter6.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerSemiFinal3.Content = ButtonPlayerQuarter5.Content;
        }

        private void PlayerQuarter6_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter5.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter6.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerSemiFinal3.Content = ButtonPlayerQuarter6.Content;
        }

        private void PlayerQuarter7_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter7.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerQuarter8.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerSemiFinal4.Content = ButtonPlayerQuarter7.Content;
        }

        private void PlayerQuarter8_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter7.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerQuarter8.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerSemiFinal4.Content = ButtonPlayerQuarter8.Content;
        }
        #endregion

        #region Кнопки 1/2
        private void PlayerSemiFinal1_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerSemiFinal2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonFinalist1.Content = ButtonPlayerSemiFinal1.Content;
            ButtonFinalist3.Content = ButtonPlayerSemiFinal2.Content;
        }

        private void PlayerSemiFinal2_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerSemiFinal2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonFinalist1.Content = ButtonPlayerSemiFinal2.Content;
            ButtonFinalist3.Content = ButtonPlayerSemiFinal1.Content;
        }

        private void PlayerSemiFinal3_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonPlayerSemiFinal4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonFinalist2.Content = ButtonPlayerSemiFinal3.Content;
            ButtonFinalist4.Content = ButtonPlayerSemiFinal4.Content;
        }

        private void PlayerSemiFinal4_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonPlayerSemiFinal4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonFinalist2.Content = ButtonPlayerSemiFinal4.Content;
            ButtonFinalist4.Content = ButtonPlayerSemiFinal3.Content;
        }

        #endregion

        #region Кнопки Финал
        private void Finalist1_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonFinalist2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
        }

        private void Finalist2_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonFinalist2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
        }

        private void Finalist3_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            ButtonFinalist4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
        }

        private void Finalist4_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            ButtonFinalist4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
        }

        #endregion

        #endregion

        /// <summary>
        /// Генерация парной турнирной сетки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PairGameGeneration(object sender, RoutedEventArgs e)
        {
            List<string> Players = (new string[] { "Инсаф", "Радис", "Юрий", "Рустем", "Алмас", "Александр Ф.", "Артем П.", "Сергей О.",
                                            "Даниил", "Линар", "Евгений Д.", "Раушан", "Ильнар", "Александр Д.", "Артур", "Фаиль" }).ToList(); //список

            PairPlayer1.Content = GetRandomElement(Players);

            PairPlayer2.Content = GetRandomElement(Players);

            PairPlayer3.Content = GetRandomElement(Players);

            PairPlayer4.Content = GetRandomElement(Players);

            PairPlayer5.Content = GetRandomElement(Players);

            PairPlayer6.Content = GetRandomElement(Players);

            PairPlayer7.Content = GetRandomElement(Players);

            PairPlayer8.Content = GetRandomElement(Players);

            PairPlayer9.Content = GetRandomElement(Players);

            PairPlayer10.Content = GetRandomElement(Players);

            PairPlayer11.Content = GetRandomElement(Players);

            PairPlayer12.Content = GetRandomElement(Players);

            PairPlayer13.Content = GetRandomElement(Players);

            PairPlayer14.Content = GetRandomElement(Players);

            PairPlayer15.Content = GetRandomElement(Players);

            PairPlayer16.Content = GetRandomElement(Players);
        }


        /// <summary>
        /// Очистка турнирной сетки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear(object sender, RoutedEventArgs e)
        {
            #region Очистка Одиночной турнирной сетки

            // Очистка 1/8
            ButtonPlayer1.Background = ButtonPlayer2.Background = ButtonPlayer3.Background = ButtonPlayer4.Background = 
                ButtonPlayer5.Background =  ButtonPlayer6.Background = ButtonPlayer7.Background = ButtonPlayer8.Background = 
                ButtonPlayer9.Background = ButtonPlayer10.Background = ButtonPlayer11.Background = ButtonPlayer12.Background = 
                ButtonPlayer13.Background = ButtonPlayer14.Background = ButtonPlayer15.Background = ButtonPlayer16.Background =  null;

            ButtonPlayer1.Content = ButtonPlayer2.Content = ButtonPlayer3.Content = ButtonPlayer4.Content = ButtonPlayer5.Content = 
                ButtonPlayer6.Content = ButtonPlayer7.Content = ButtonPlayer8.Content = ButtonPlayer9.Content = 
                ButtonPlayer10.Content = ButtonPlayer11.Content = ButtonPlayer12.Content = ButtonPlayer13.Content = 
                ButtonPlayer14.Content = ButtonPlayer15.Content = ButtonPlayer16.Content = null;

            // Очистка 1/4
            ButtonPlayerQuarter1.Background = ButtonPlayerQuarter2.Background = ButtonPlayerQuarter3.Background = ButtonPlayerQuarter4.Background =
                ButtonPlayerQuarter5.Background = ButtonPlayerQuarter6.Background = ButtonPlayerQuarter7.Background = ButtonPlayerQuarter8.Background = null;

            ButtonPlayerQuarter1.Content = ButtonPlayerQuarter2.Content = ButtonPlayerQuarter3.Content = ButtonPlayerQuarter4.Content =
                ButtonPlayerQuarter5.Content = ButtonPlayerQuarter6.Content = ButtonPlayerQuarter7.Content = ButtonPlayerQuarter8.Content = null;

            // Очистка 1/2
            ButtonPlayerSemiFinal1.Background = ButtonPlayerSemiFinal2.Background = 
                ButtonPlayerSemiFinal3.Background = ButtonPlayerSemiFinal4.Background = null;

            ButtonPlayerSemiFinal1.Content = ButtonPlayerSemiFinal2.Content =
                ButtonPlayerSemiFinal3.Content = ButtonPlayerSemiFinal4.Content = null;

            // Очистка Финал
            ButtonFinalist1.Background = ButtonFinalist2.Background =
                ButtonFinalist3.Background = ButtonFinalist4.Background = null;

            ButtonFinalist1.Content = ButtonFinalist2.Content =
                ButtonFinalist3.Content = ButtonFinalist4.Content = null;
            #endregion
        }

        #region Прохождения игроков по парной турнирной сетке

        private void FirstPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));

            SemiFinalPairPlayer1.Content = PairPlayer1.Content;
            SemiFinalPairPlayer2.Content = PairPlayer2.Content;
        }
      
        private void SecondPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));          

            SemiFinalPairPlayer1.Content = PairPlayer3.Content;
            SemiFinalPairPlayer2.Content = PairPlayer4.Content;
        }

        private void ThirdPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer5.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer6.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer7.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer8.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));

            SemiFinalPairPlayer3.Content = PairPlayer5.Content;
            SemiFinalPairPlayer4.Content = PairPlayer6.Content;
        }

        private void FourthPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer5.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer6.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer7.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer8.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));

            SemiFinalPairPlayer3.Content = PairPlayer7.Content;
            SemiFinalPairPlayer4.Content = PairPlayer8.Content;
        }

        private void Fifth_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer9.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer10.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer11.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer12.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));

            SemiFinalPairPlayer5.Content = PairPlayer9.Content;
            SemiFinalPairPlayer6.Content = PairPlayer10.Content;
        }

        private void SixthPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer9.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer10.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer11.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer12.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));

            SemiFinalPairPlayer5.Content = PairPlayer11.Content;
            SemiFinalPairPlayer6.Content = PairPlayer12.Content;
        }

        private void SeventhPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer13.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer14.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer15.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer16.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));

            SemiFinalPairPlayer7.Content = PairPlayer13.Content;
            SemiFinalPairPlayer8.Content = PairPlayer14.Content;
        }

        private void EighthPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairPlayer13.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer14.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairPlayer15.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairPlayer16.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));

            SemiFinalPairPlayer7.Content = PairPlayer15.Content;
            SemiFinalPairPlayer8.Content = PairPlayer16.Content;
        }

        private void SemiFinalFirstPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            SemiFinalPairPlayer2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            SemiFinalPairPlayer3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            SemiFinalPairPlayer4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));

            PairFinalist1.Content = SemiFinalPairPlayer1.Content;
            PairFinalist2.Content = SemiFinalPairPlayer2.Content;
            PairFinalist5.Content = SemiFinalPairPlayer3.Content;
            PairFinalist6.Content = SemiFinalPairPlayer4.Content;
        }

        private void SemiFinalSecondPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            SemiFinalPairPlayer2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            SemiFinalPairPlayer3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            SemiFinalPairPlayer4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));

            PairFinalist1.Content = SemiFinalPairPlayer3.Content;
            PairFinalist2.Content = SemiFinalPairPlayer4.Content;
            PairFinalist5.Content = SemiFinalPairPlayer1.Content;
            PairFinalist6.Content = SemiFinalPairPlayer2.Content;
        }

        private void SemiFinalThirdPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer5.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            SemiFinalPairPlayer6.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            SemiFinalPairPlayer7.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            SemiFinalPairPlayer8.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));

            PairFinalist3.Content = SemiFinalPairPlayer5.Content;
            PairFinalist4.Content = SemiFinalPairPlayer6.Content;
            PairFinalist7.Content = SemiFinalPairPlayer7.Content;
            PairFinalist8.Content = SemiFinalPairPlayer8.Content;
        }

        private void SemiFinalFourthPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer5.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            SemiFinalPairPlayer6.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            SemiFinalPairPlayer7.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            SemiFinalPairPlayer8.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));

            PairFinalist3.Content = SemiFinalPairPlayer7.Content;
            PairFinalist4.Content = SemiFinalPairPlayer8.Content;
            PairFinalist7.Content = SemiFinalPairPlayer5.Content;
            PairFinalist8.Content = SemiFinalPairPlayer6.Content;
        }

        private void FinalFirstPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist1.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairFinalist2.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairFinalist3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairFinalist4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
        }

        private void FinalSecondPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairFinalist2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairFinalist3.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairFinalist4.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
        }

        private void FinalThirdPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist5.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairFinalist6.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairFinalist7.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairFinalist8.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
        }

        private void FinalFourthPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist5.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairFinalist6.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            PairFinalist7.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));
            PairFinalist8.Background = new SolidColorBrush(Color.FromRgb(2, 190, 0));

        }
        #endregion
    }
}
