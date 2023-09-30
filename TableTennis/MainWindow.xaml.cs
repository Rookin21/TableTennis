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

        #region Кнопки прохождения игроков по одиночной турнирной сетке

        #region Кнопки 1/8

        private void ButtonPlayer1_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter1.Content = ButtonPlayer1.Content;
            ButtonPlayer2.IsEnabled = false;
        }

        private void ButtonPlayer2_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter1.Content = ButtonPlayer2.Content;
            ButtonPlayer1.IsEnabled = false;
        }

        private void ButtonPlayer3_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter2.Content = ButtonPlayer3.Content;
            ButtonPlayer4.IsEnabled = false;
        }

        private void ButtonPlayer4_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter2.Content = ButtonPlayer4.Content;
            ButtonPlayer3.IsEnabled = false;
        }

        private void ButtonPlayer5_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter3.Content = ButtonPlayer5.Content;
            ButtonPlayer6.IsEnabled = false;
        }

        private void ButtonPlayer6_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter3.Content = ButtonPlayer6.Content;
            ButtonPlayer5.IsEnabled = false;
        }

        private void ButtonPlayer7_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter4.Content = ButtonPlayer7.Content;
            ButtonPlayer8.IsEnabled = false;
        }

        private void ButtonPlayer8_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter4.Content = ButtonPlayer8.Content;
            ButtonPlayer7.IsEnabled = false;
        }

        private void ButtonPlayer9_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter5.Content = ButtonPlayer9.Content;
            ButtonPlayer10.IsEnabled = false;
        }

        private void ButtonPlayer10_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter5.Content = ButtonPlayer10.Content;
            ButtonPlayer9.IsEnabled = false;
        }

        private void ButtonPlayer11_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter6.Content = ButtonPlayer11.Content;
            ButtonPlayer12.IsEnabled = false;
        }

        private void ButtonPlayer12_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter6.Content = ButtonPlayer12.Content;
            ButtonPlayer11.IsEnabled = false;
        }

        private void ButtonPlayer13_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter7.Content = ButtonPlayer13.Content;
            ButtonPlayer14.IsEnabled = false;
        }

        private void ButtonPlayer14_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter7.Content = ButtonPlayer14.Content;
            ButtonPlayer13.IsEnabled = false;
        }

        private void ButtonPlayer15_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter8.Content = ButtonPlayer15.Content;
            ButtonPlayer16.IsEnabled = false;
        }

        private void ButtonPlayer16_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerQuarter8.Content = ButtonPlayer16.Content;
            ButtonPlayer15.IsEnabled = false;
        }

        #endregion

        #region Кнопки 1/4

        private void PlayerQuarter1_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal1.Content = ButtonPlayerQuarter1.Content;
            ButtonPlayerQuarter2.IsEnabled = false;
        }

        private void PlayerQuarter2_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal1.Content = ButtonPlayerQuarter2.Content;
            ButtonPlayerQuarter1.IsEnabled = false;
        }

        private void PlayerQuarter3_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal2.Content = ButtonPlayerQuarter3.Content;
            ButtonPlayerQuarter4.IsEnabled = false;
        }

        private void PlayerQuarter4_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal2.Content = ButtonPlayerQuarter4.Content;
            ButtonPlayerQuarter3.IsEnabled = false;
        }

        private void PlayerQuarter5_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal3.Content = ButtonPlayerQuarter5.Content;
            ButtonPlayerQuarter6.IsEnabled = false;
        }

        private void PlayerQuarter6_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal3.Content = ButtonPlayerQuarter6.Content;
            ButtonPlayerQuarter5.IsEnabled = false;
        }

        private void PlayerQuarter7_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal4.Content = ButtonPlayerQuarter7.Content;
            ButtonPlayerQuarter8.IsEnabled = false;
        }

        private void PlayerQuarter8_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlayerSemiFinal4.Content = ButtonPlayerQuarter8.Content;
            ButtonPlayerQuarter7.IsEnabled = false;
        }
        #endregion

        #region Кнопки 1/2
        private void PlayerSemiFinal1_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist1.Content = ButtonPlayerSemiFinal1.Content;
            ButtonFinalist3.Content = ButtonPlayerSemiFinal2.Content;
            ButtonPlayerSemiFinal2.IsEnabled = false;
        }

        private void PlayerSemiFinal2_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist1.Content = ButtonPlayerSemiFinal2.Content;
            ButtonFinalist3.Content = ButtonPlayerSemiFinal1.Content;
            ButtonPlayerSemiFinal1.IsEnabled = false;
        }

        private void PlayerSemiFinal3_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist2.Content = ButtonPlayerSemiFinal3.Content;
            ButtonFinalist4.Content = ButtonPlayerSemiFinal4.Content;
            ButtonPlayerSemiFinal4.IsEnabled = false;
        }

        private void PlayerSemiFinal4_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist2.Content = ButtonPlayerSemiFinal4.Content;
            ButtonFinalist4.Content = ButtonPlayerSemiFinal3.Content;
            ButtonPlayerSemiFinal3.IsEnabled = false;
        }

        #endregion

        #region Кнопки Финал
        private void Finalist1_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist2.IsEnabled = false;
        }

        private void Finalist2_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist1.IsEnabled = false;
        }

        private void Finalist3_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist4.IsEnabled = false;
        }

        private void Finalist4_Click(object sender, RoutedEventArgs e)
        {
            ButtonFinalist3.IsEnabled = false;
        }

        #endregion

        #endregion

        #region Прохождения игроков по парной турнирной сетке

        private void FirstPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer1.Content = PairPlayer1.Content;
            SemiFinalPairPlayer2.Content = PairPlayer2.Content;
            PairPlayer3.IsEnabled = false;
            PairPlayer4.IsEnabled = false;
            SecondPairWon.IsEnabled = false;
        }

        private void SecondPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer1.Content = PairPlayer3.Content;
            SemiFinalPairPlayer2.Content = PairPlayer4.Content;
            PairPlayer1.IsEnabled = false;
            PairPlayer2.IsEnabled = false;
            FisrtPairWon.IsEnabled = false;
        }

        private void ThirdPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer3.Content = PairPlayer5.Content;
            SemiFinalPairPlayer4.Content = PairPlayer6.Content;
            PairPlayer7.IsEnabled = false;
            PairPlayer8.IsEnabled = false;
            FourthPairWon.IsEnabled = false;
        }

        private void FourthPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer3.Content = PairPlayer7.Content;
            SemiFinalPairPlayer4.Content = PairPlayer8.Content;
            PairPlayer5.IsEnabled = false;
            PairPlayer6.IsEnabled = false;
            ThirdPairWon.IsEnabled = false;
        }

        private void FifthPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer5.Content = PairPlayer9.Content;
            SemiFinalPairPlayer6.Content = PairPlayer10.Content;
            PairPlayer11.IsEnabled = false;
            PairPlayer12.IsEnabled = false;
            SixthPairWon.IsEnabled = false;
        }

        private void SixthPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer5.Content = PairPlayer11.Content;
            SemiFinalPairPlayer6.Content = PairPlayer12.Content;
            PairPlayer9.IsEnabled = false;
            PairPlayer10.IsEnabled = false;
            FifthPairWon.IsEnabled = false;
        }

        private void SeventhPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer7.Content = PairPlayer13.Content;
            SemiFinalPairPlayer8.Content = PairPlayer14.Content;
            PairPlayer15.IsEnabled = false;
            PairPlayer16.IsEnabled = false;
            EighthPairWon.IsEnabled = false;
        }

        private void EighthPairWon_Click(object sender, RoutedEventArgs e)
        {
            SemiFinalPairPlayer7.Content = PairPlayer15.Content;
            SemiFinalPairPlayer8.Content = PairPlayer16.Content;
            PairPlayer13.IsEnabled = false;
            PairPlayer14.IsEnabled = false;
            SeventhPairWon.IsEnabled = false;
        }

        private void SemiFinalFirstPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist1.Content = SemiFinalPairPlayer1.Content;
            PairFinalist2.Content = SemiFinalPairPlayer2.Content;
            PairFinalist5.Content = SemiFinalPairPlayer3.Content;
            PairFinalist6.Content = SemiFinalPairPlayer4.Content;

            SemiFinalPairPlayer3.IsEnabled = false;
            SemiFinalPairPlayer4.IsEnabled = false;
            SemiFinalSecondPairWon.IsEnabled = false;

        }

        private void SemiFinalSecondPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist1.Content = SemiFinalPairPlayer3.Content;
            PairFinalist2.Content = SemiFinalPairPlayer4.Content;
            PairFinalist5.Content = SemiFinalPairPlayer1.Content;
            PairFinalist6.Content = SemiFinalPairPlayer2.Content;

            SemiFinalPairPlayer1.IsEnabled = false;
            SemiFinalPairPlayer2.IsEnabled = false;
            SemiFinalFirstPairWon.IsEnabled = false;
        }

        private void SemiFinalThirdPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist3.Content = SemiFinalPairPlayer5.Content;
            PairFinalist4.Content = SemiFinalPairPlayer6.Content;
            PairFinalist7.Content = SemiFinalPairPlayer7.Content;
            PairFinalist8.Content = SemiFinalPairPlayer8.Content;

            SemiFinalPairPlayer7.IsEnabled = false;
            SemiFinalPairPlayer8.IsEnabled = false;
            SemiFinalFourthPairWon.IsEnabled = false;
        }

        private void SemiFinalFourthPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist3.Content = SemiFinalPairPlayer7.Content;
            PairFinalist4.Content = SemiFinalPairPlayer8.Content;
            PairFinalist7.Content = SemiFinalPairPlayer5.Content;
            PairFinalist8.Content = SemiFinalPairPlayer6.Content;

            SemiFinalPairPlayer5.IsEnabled = false;
            SemiFinalPairPlayer6.IsEnabled = false;
            SemiFinalThirdPairWon.IsEnabled = false;
        }

        private void FinalFirstPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist3.IsEnabled = false;
            PairFinalist4.IsEnabled = false;
            FinalSecondPairWon.IsEnabled = false;
        }

        private void FinalSecondPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist1.IsEnabled = false;
            PairFinalist2.IsEnabled = false;
            FinalFirstPairWon.IsEnabled = false;
        }

        private void FinalThirdPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist7.IsEnabled = false;
            PairFinalist8.IsEnabled = false;
            FinalFourthPairWon.IsEnabled = false;
        }

        private void FinalFourthPairWon_Click(object sender, RoutedEventArgs e)
        {
            PairFinalist5.IsEnabled = false;
            PairFinalist6.IsEnabled = false;
            FinalThirdPairWon.IsEnabled = false;
        }
        #endregion

        /// <summary>
        /// Очистка турнирной сетки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear(object sender, RoutedEventArgs e)
        {
            #region Очистка Одиночной турнирной сетки

            // Очистка 1/8
            ButtonPlayer1.IsEnabled = ButtonPlayer2.IsEnabled = ButtonPlayer3.IsEnabled = ButtonPlayer4.IsEnabled =
                ButtonPlayer5.IsEnabled = ButtonPlayer6.IsEnabled = ButtonPlayer7.IsEnabled = ButtonPlayer8.IsEnabled =
                ButtonPlayer9.IsEnabled = ButtonPlayer10.IsEnabled = ButtonPlayer11.IsEnabled = ButtonPlayer12.IsEnabled =
                ButtonPlayer13.IsEnabled = ButtonPlayer14.IsEnabled = ButtonPlayer15.IsEnabled = ButtonPlayer16.IsEnabled = true;

            ButtonPlayer1.Content = ButtonPlayer2.Content = ButtonPlayer3.Content = ButtonPlayer4.Content = ButtonPlayer5.Content =
                ButtonPlayer6.Content = ButtonPlayer7.Content = ButtonPlayer8.Content = ButtonPlayer9.Content =
                ButtonPlayer10.Content = ButtonPlayer11.Content = ButtonPlayer12.Content = ButtonPlayer13.Content =
                ButtonPlayer14.Content = ButtonPlayer15.Content = ButtonPlayer16.Content = null;

            // Очистка 1/4
            ButtonPlayerQuarter1.IsEnabled = ButtonPlayerQuarter2.IsEnabled = ButtonPlayerQuarter3.IsEnabled = ButtonPlayerQuarter4.IsEnabled =
                ButtonPlayerQuarter5.IsEnabled = ButtonPlayerQuarter6.IsEnabled = ButtonPlayerQuarter7.IsEnabled = ButtonPlayerQuarter8.IsEnabled = true;

            ButtonPlayerQuarter1.Content = ButtonPlayerQuarter2.Content = ButtonPlayerQuarter3.Content = ButtonPlayerQuarter4.Content =
                ButtonPlayerQuarter5.Content = ButtonPlayerQuarter6.Content = ButtonPlayerQuarter7.Content = ButtonPlayerQuarter8.Content = null;

            // Очистка 1/2
            ButtonPlayerSemiFinal1.IsEnabled = ButtonPlayerSemiFinal2.IsEnabled =
                ButtonPlayerSemiFinal3.IsEnabled = ButtonPlayerSemiFinal4.IsEnabled = true;

            ButtonPlayerSemiFinal1.Content = ButtonPlayerSemiFinal2.Content =
                ButtonPlayerSemiFinal3.Content = ButtonPlayerSemiFinal4.Content = null;

            // Очистка Финал
            ButtonFinalist1.IsEnabled = ButtonFinalist2.IsEnabled =
                ButtonFinalist3.IsEnabled = ButtonFinalist4.IsEnabled = true;

            ButtonFinalist1.Content = ButtonFinalist2.Content =
                ButtonFinalist3.Content = ButtonFinalist4.Content = null;
            #endregion

            #region Очистка парной турнирной сетки

            // Очистка 1/4
            PairPlayer1.IsEnabled = PairPlayer2.IsEnabled = PairPlayer3.IsEnabled = PairPlayer4.IsEnabled = PairPlayer5.IsEnabled =
                PairPlayer6.IsEnabled = PairPlayer7.IsEnabled = PairPlayer8.IsEnabled = PairPlayer9.IsEnabled = PairPlayer10.IsEnabled =
                PairPlayer11.IsEnabled = PairPlayer12.IsEnabled = PairPlayer13.IsEnabled = PairPlayer14.IsEnabled = PairPlayer15.IsEnabled =
                PairPlayer16.IsEnabled = true;

            PairPlayer1.Content = PairPlayer2.Content = PairPlayer3.Content = PairPlayer4.Content = PairPlayer5.Content =
                PairPlayer6.Content = PairPlayer7.Content = PairPlayer8.Content = PairPlayer9.Content = PairPlayer10.Content =
                PairPlayer11.Content = PairPlayer12.Content = PairPlayer13.Content = PairPlayer14.Content = PairPlayer15.Content =
                PairPlayer16.Content = null;

            FisrtPairWon.IsEnabled = SecondPairWon.IsEnabled = ThirdPairWon.IsEnabled = FourthPairWon.IsEnabled =
                FifthPairWon.IsEnabled = SixthPairWon.IsEnabled = SeventhPairWon.IsEnabled = EighthPairWon.IsEnabled = true;

            FisrtPairWon.IsChecked = SecondPairWon.IsChecked = ThirdPairWon.IsChecked = FourthPairWon.IsChecked =
                FifthPairWon.IsChecked = SixthPairWon.IsChecked = SeventhPairWon.IsChecked = EighthPairWon.IsChecked = false;

            // Очистка 1/2
            SemiFinalPairPlayer1.IsEnabled = SemiFinalPairPlayer2.IsEnabled = SemiFinalPairPlayer3.IsEnabled =
                SemiFinalPairPlayer4.IsEnabled = SemiFinalPairPlayer5.IsEnabled = SemiFinalPairPlayer6.IsEnabled =
                SemiFinalPairPlayer7.IsEnabled = SemiFinalPairPlayer8.IsEnabled = true;

            SemiFinalPairPlayer1.Content = SemiFinalPairPlayer2.Content = SemiFinalPairPlayer3.Content =
                SemiFinalPairPlayer4.Content = SemiFinalPairPlayer5.Content = SemiFinalPairPlayer6.Content =
                SemiFinalPairPlayer7.Content = SemiFinalPairPlayer8.Content = null;

            SemiFinalFirstPairWon.IsEnabled = SemiFinalSecondPairWon.IsEnabled = SemiFinalThirdPairWon.IsEnabled =
                SemiFinalFourthPairWon.IsEnabled = true;

            SemiFinalFirstPairWon.IsChecked = SemiFinalSecondPairWon.IsChecked = SemiFinalThirdPairWon.IsChecked =
                SemiFinalFourthPairWon.IsChecked = false;

            // Очистка Финал
            PairFinalist1.IsEnabled = PairFinalist2.IsEnabled = PairFinalist3.IsEnabled = PairFinalist4.IsEnabled =
                PairFinalist5.IsEnabled = PairFinalist6.IsEnabled = PairFinalist7.IsEnabled = PairFinalist8.IsEnabled = true;

            PairFinalist1.Content = PairFinalist2.Content = PairFinalist3.Content = PairFinalist4.Content =
                PairFinalist5.Content = PairFinalist6.Content = PairFinalist7.Content = PairFinalist8.Content = null;

            FinalFirstPairWon.IsEnabled = FinalSecondPairWon.IsEnabled = FinalThirdPairWon.IsEnabled = FinalFourthPairWon.IsEnabled = true;

            FinalFirstPairWon.IsChecked = FinalSecondPairWon.IsChecked = FinalThirdPairWon.IsChecked = FinalFourthPairWon.IsChecked = false;

            #endregion
        }

        
    }
}
