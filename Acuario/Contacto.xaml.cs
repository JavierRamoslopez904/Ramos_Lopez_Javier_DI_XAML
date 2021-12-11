using Acuario.Clases;
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
    /// Lógica de interacción para Contacto.xaml
    /// </summary>
    public partial class Contacto : Window
    {
        public Logica logica;
        private int index;


        public Contacto()
        {
            InitializeComponent();
            this.index = -1;
            logica = new Logica();

            this.DataContext = logica;
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void enviar(object sender, RoutedEventArgs e)
        {
            sugerencias.Clear();
        }
    }
}
