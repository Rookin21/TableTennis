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
        List<string> list = (new string[] { "Айдар", "Александр Д.", "Александр Ф.", "Алмас", "Артем П." }).ToList(); //список

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generation(object sender, RoutedEventArgs e)
        {
            Label1.Content = list[new Random().Next(list.Count)];
            Label2.Content = list[new Random().Next(list.Count)];
            Label3.Content = list[new Random().Next(list.Count)];
            Label4.Content = list[new Random().Next(list.Count)];
            Label5.Content = list[new Random().Next(list.Count)];
        }
    }
}
