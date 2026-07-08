using System;
using System.Collections.Generic;
using System.Text;

namespace torneo_POO.MODELS
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public List<Jugador> Jugadores { get; set; }


        public Equipo(string nombre, string ciudad)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador objJugador)
        {
            //  Si el objeto que pasan es nulo, lanzamos un error o un aviso
            if (objJugador == null)
            {
                Console.WriteLine("Error: No se puede agregar un jugador nulo al equipo.");
                return; 
            }
            this.Jugadores.Add(objJugador);
            Console.WriteLine($"Jugador {objJugador.Nombre} agregado correctamente");
        }

        public void ListarPlantilla()
        {
            Console.WriteLine($"La lista de jugadores del equipo {this.Nombre} de la ciudad de {this.Ciudad} es:");
            foreach (Jugador objJugador in Jugadores)
            {
                objJugador.Presentar();
            }
        }

        public bool TienePlantillaMinima()
        {
       
            return this.Jugadores.Count >= 2;
        }


        
    }
}