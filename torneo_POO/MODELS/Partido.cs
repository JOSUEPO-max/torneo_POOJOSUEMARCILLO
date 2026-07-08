using System;
using System.Collections.Generic;
using System.Text;

namespace torneo_POO.MODELS
{
    public class Jugador
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Numero { get; set; }
        public string Posicion { get; set; }


        public void Presentar()
        {
            Console.WriteLine($"Hola soy {this.Nombre} tengo {this.Edad} años y mi número es el {this.Numero}");
        }
    }
}