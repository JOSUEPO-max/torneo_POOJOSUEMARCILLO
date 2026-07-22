using System;
using System.Collections.Generic;
using System.Text;

namespace torneo_POO.MODELS
{
    public class Equipo
    {
        private string nombre;
        private string ciudad;
        private List<Jugador> jugadores;
        private string directortecnico;
        private int suplentes;
        private string alineacion;
        private int id;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public int Id { get => this.id; set => this.id = value; }

        public string Directortecnico 
        { 
            get => directortecnico; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre del director técnico no puede estar vacío.");
                }
                directortecnico = value;
            } 
        }
        public int Suplentes 
        { 
            get => suplentes; 
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new Exception( "La cantidad de suplentes debe estar entre 0 y 15.");
                }
                suplentes = value;
            }
        }
        public string Alineacion 
        { 
            get => alineacion; 
            set

            {
                string valorLimpio = value.Trim().ToLower();
                string[] alineacionesValidas = {
            "cuatro tres tres",
            "cuatro cuatro dos",
            "tres cinco dos",
            "cinco tres dos"
             };
                if (!System.Linq.Enumerable.Contains(alineacionesValidas, valorLimpio))
                {
                   throw new ArgumentException($"La alineación '{value}' no es válida" );
                }
                alineacion = valorLimpio;
            }
        }

       
        public Equipo(string nombre, string ciudad, string directortecnico, int suplentes, string alineacion)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Jugadores = new List<Jugador>();
            this.Directortecnico = directortecnico;
            this.Suplentes = suplentes;
            this.Alineacion = alineacion;
        }



        public void AgregarJugador(Jugador objJugador)
        {
            // Validacion de objetos nulos en la plantilla de equipo
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
        public void Imprimir()
        {

            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine($"Nombre del equipo: {this.Nombre}");
            Console.WriteLine($"Ciudad del equipo: {this.Ciudad}");
            Console.WriteLine($"Color del equipo: {this.directortecnico}");
            ListarPlantilla();
        }


    }
}

