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

            for (int i = 0; i < 8; i++)
            {
                tabla.RowDefinitions.Add(new RowDefinition());
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Rectangle mezo = new Rectangle();
                    tabla.Children.Add(mezo);
                    if (i % 2 == 1 && j % 2 == 0)
                    {
                        mezo.Fill = Brushes.White;
                        mezo.Stroke = Brushes.Black;
                    }
                    else if (i % 2 == 0 && j % 2 == 1)
                    {
                        mezo.Fill = Brushes.White;
                        mezo.Stroke = Brushes.Black;
                    }
                    else
                    {
                        mezo.Fill = Brushes.Black;
                        mezo.Stroke = Brushes.Black;
                    }
                    Grid.SetRow(mezo, j);
                    Grid.SetColumn(mezo, i);
                }
            }
        }
    }
}
