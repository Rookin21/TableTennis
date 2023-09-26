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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generation(object sender, RoutedEventArgs e)
        {
            List<string> Players = (new string[] { "Инсаф", "Радис", "Юрий", "Рустем", "Алмас", "Александр Ф.", "Артем П.", "Сергей О.",
                                            "Даниил", "Линар", "Евгений Д.", "Раушан", "Ильнар", "Александр Д.", "Артур", "Фаиль" }).ToList(); //список
           
            Label1.Content = GetRandomElement(Players); ;

            Label2.Content = GetRandomElement(Players); ;

            Label3.Content = GetRandomElement(Players); ;

            Label4.Content = GetRandomElement(Players); ;

            Label5.Content = GetRandomElement(Players); ;

            Label6.Content = GetRandomElement(Players); ;

            Label7.Content = GetRandomElement(Players); ;

            Label8.Content = GetRandomElement(Players); ;

            Label9.Content = GetRandomElement(Players); ;

            Label10.Content = GetRandomElement(Players); ;

            Label11.Content = GetRandomElement(Players); ;

            Label12.Content = GetRandomElement(Players); ;

            Label13.Content = GetRandomElement(Players); ;

            Label14.Content = GetRandomElement(Players); ;

            Label15.Content = GetRandomElement(Players);;

            Label16.Content = GetRandomElement(Players);
        }

        public string GetRandomElement(List<string> Players)
        {
            string RandomPlayer = Players[new Random().Next(Players.Count)];
            Players.Remove(RandomPlayer);
            return RandomPlayer;
        }
    }
}
