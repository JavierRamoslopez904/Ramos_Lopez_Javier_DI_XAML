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
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void goToSalas(object sender, RoutedEventArgs e)
        {
            SalasDelAcuario sda = new SalasDelAcuario();
            this.Close();
            sda.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void goToMinijuego(object sender, RoutedEventArgs e)
        {
            Minijuego m = new Minijuego();
            this.Close();
            m.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void goToContacto(object sender, RoutedEventArgs e)
        {
            Contacto c = new Contacto();
            this.Close();
            c.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void goToControlPiscina(object sender, RoutedEventArgs e)
        {
            ControlPiscinaAcuario cpa = new ControlPiscinaAcuario();
            this.Close();
            cpa.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }
    }
}
