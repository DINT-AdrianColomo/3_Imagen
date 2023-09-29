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

namespace _3_Imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AltaButton_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Opacity = 1;
        }

        private void BajaButton_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Opacity = 0.3;
        }

        private void MediaButton_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Opacity = 0.6;
        }

        private void FillButton_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch = Stretch.Fill;
        }

        private void UniformButton_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch=Stretch.Uniform;
        }

        private void UniformToFillButton_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch=Stretch.UniformToFill;
        }

        private void NoneButton_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch = Stretch.None;
        }
    }
}
