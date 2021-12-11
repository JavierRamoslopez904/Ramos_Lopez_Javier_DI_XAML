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
    /// Lógica de interacción para ControlPiscinaAcuario.xaml
    /// </summary>
    public partial class ControlPiscinaAcuario : Window
    {
        public static Logica logic = new Logica();

        public ControlPiscinaAcuario()
        {
            InitializeComponent();
            datagridAcuario.DataContext = logic;
        }

        private void agregarAnimal(object sender, RoutedEventArgs e)
        {
            new ControlAnimales().Show();
        }

        private void modificarAnimal(object sender, RoutedEventArgs e)
        {
            if (datagridAcuario.SelectedIndex != -1) {
                new ControlAnimales(datagridAcuario.SelectedIndex).Show();
            }
        }

        private void eliminarAnimal(object sender, RoutedEventArgs e)
        {
            if (datagridAcuario.SelectedIndex != -1)
            {
                logic.deleteAnimal(datagridAcuario.SelectedIndex);
            }
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
    }
}
