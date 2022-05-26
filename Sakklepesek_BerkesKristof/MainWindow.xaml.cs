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

namespace Sakklepesek_BerkesKristof
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TablaGeneralas();
        }

        private void Kattintas(object sender, RoutedEventArgs e)
        {
            int col = 0;
            Button mezo = sender as Button;
            mezo.Background = Brushes.Red;
        }

        public void TablaGeneralas()
        {
            for (int i = 0; i < 8; i++)
            {
                tabla.RowDefinitions.Add(new RowDefinition());
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button mezo = new Button();
                    if (i % 2 == 1 && j % 2 == 0)
                    {
                        mezo.Background = Brushes.White;

                    }
                    else if (i % 2 == 0 && j % 2 == 1)
                    {
                        mezo.Background = Brushes.White;

                    }
                    else
                    {
                        mezo.Background = Brushes.Black;

                    }
                    Grid.SetRow(mezo, j);
                    Grid.SetColumn(mezo, i);
                    mezo.Click += Kattintas;
                    tabla.Children.Add(mezo);


                }
            }
            
        }
    }
}
