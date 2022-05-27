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
using System.IO;

namespace Sakklepesek_BerkesKristof
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] mezok = new Button[8,8];
        public MainWindow()
        {
            InitializeComponent();
            TablaGeneralas();
        }
        public void Cbox()
        {
            cbox.Items.Add("gyalog");
        }
        private void Kattintas(object sender, RoutedEventArgs e)
        {
            //int col = 0;
            Button aktualis = sender as Button;
            int x = -1, y = -1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mezok[i,j].Equals(aktualis))
                    {
                        x = i;
                        y = j;
                    }
                    if ((i+j)%2 == 0)
                    {
                        mezok[i, j].Background = Brushes.White;
                    }
                    else
                    {
                        mezok[i, j].Background = Brushes.Black;
                    }
                }
            }
            aktualis.Background = Brushes.Red;
        }

        public void TablaGeneralas()
        {
            for (int i = 0; i < 8; i++)
            {
                tabla.RowDefinitions.Add(new RowDefinition());
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Label koord = new Label();
                    if ((i + j) % 2 == 0)
                    {
                        koord.Content = "A";
                    }

                    else
                    {
                        koord.Content = "1";
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button mezo = new Button();
                    if ((i + j) % 2 == 0)
                    {
                        mezo.Background = Brushes.White;

                    }

                    else
                    {
                        mezo.Background = Brushes.Black;

                    }
                    mezok[i, j] = mezo;
                    Grid.SetRow(mezok[i,j], j);
                    Grid.SetColumn(mezok[i,j], i);
                    mezo.Click += Kattintas;
                    tabla.Children.Add(mezok[i,j]);


                }
            }
            
        }
    }
}
