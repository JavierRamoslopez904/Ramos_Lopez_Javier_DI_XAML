using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Acuario
{
    public class Control
    {

        public static List<String> salas = new List<String>() {"Mamíferos", "Crustaceos","Tropical"};

        public String nombreDeLaSala { get; set; }
        public String temperatura { get; set; }
        public String especies { get; set; }
        public DateTime ultimaRevision { get; set; }
        public String tratamientoRealizado { get; set; }

        public Control()
        {
        }

        public Control(String nombreDeLaSala, String temperatura, String especies, DateTime ultimaRevision, String tratamientoRealizado)
        {
            this.nombreDeLaSala = nombreDeLaSala;
            this.temperatura = temperatura;
            this.especies = especies;
            this.ultimaRevision = ultimaRevision;
            this.tratamientoRealizado = tratamientoRealizado;
        }

        public event PropertyChangedEventHandler propertyChanged;

    }
}
