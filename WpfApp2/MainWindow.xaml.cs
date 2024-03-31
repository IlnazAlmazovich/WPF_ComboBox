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

namespace WpfApp2
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem s = (ComboBoxItem)CMBX.SelectedItem;
            string c = s.Content.ToString();
            switch (c)
            {
                case "Красный":
                    this.Background = Brushes.Red;
                    break;
                case "Синий":
                    this.Background = Brushes.Blue;
                    break;
                case "Жёлтый":
                    this.Background = Brushes.Yellow;
                    break;
                case "Зелёный":
                    this.Background = Brushes.Green;
                    break;
            }
        }

        private void CMBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBoxItem s = (ComboBoxItem)CMBX.SelectedItem;
            //string c = s.Content.ToString();
            //switch (c)
            //{
            //    case "Красный":
            //        this.Background = Brushes.Red;
            //        break;
            //    case "Синий":
            //        this.Background = Brushes.Blue;
            //        break;
            //    case "Жёлтый":
            //        this.Background = Brushes.Yellow;
            //        break;
            //    case "Зелёный":
            //        this.Background = Brushes.Green;
            //        break;
            //}
        }
    }
}
