using Acuario.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para ControlAnimales.xaml
    /// </summary>
    public partial class ControlAnimales : Window
    {
        public Control control;
        private int index;


        public ControlAnimales()
        {
            InitializeComponent();
            this.index = -1;
            control = new Control();
            especies.ItemsSource = Control.salas;
            this.DataContext = control;
        }

        public ControlAnimales(int index)
        {
            InitializeComponent();
            this.index = index;
            control = new Control();
            especies.ItemsSource = Control.salas;
            especies.SelectedItem = ControlPiscinaAcuario.logic.listaControl.ElementAt(index).nombreDeLaSala;
            this.DataContext = ControlPiscinaAcuario.logic.listaControl.ElementAt(index);
        }

        private void add(object sender, RoutedEventArgs e)
        {
            if (index > -1)
            {
                control = new Control(nombreDeLaSala.Text, temperatura.Text, especies.SelectedItem.ToString(), (DateTime)fecha.SelectedDate, tratamientoRealizado.Text);
                ControlPiscinaAcuario.logic.editAnimal(index, control);
                this.Close();
            }
            else
            {
                ControlPiscinaAcuario.logic.addAnimal(control);
            }

            control = new Control();
            this.DataContext = control;
        }

        private void cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
