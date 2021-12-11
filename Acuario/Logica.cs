using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Acuario.Clases
{
    public class Logica
    {
        public ObservableCollection<Control> listaControl { get; set; }

        public Logica()
        {
            listaControl = new ObservableCollection<Control>();

            listaControl.Add(new Control("Javier","43","Crustaceos",DateTime.Today,"hola"));
        }

        public void addAnimal(Control control)
        {
            listaControl.Add(control);
        }

        public void deleteAnimal(int index)
        {
            listaControl.RemoveAt(index);
        }

        public void editAnimal(int index, Control control)
        {
            listaControl[index] = control;
        }
    }
}
