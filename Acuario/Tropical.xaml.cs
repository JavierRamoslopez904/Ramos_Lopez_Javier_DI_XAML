using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Media;

namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para Tropical.xaml
    /// </summary>
    public partial class Tropical : Window
    {
        public Tropical()
        {
            InitializeComponent();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            SalasDelAcuario sda = new SalasDelAcuario();
            this.Close();
            sda.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }
    }
}
