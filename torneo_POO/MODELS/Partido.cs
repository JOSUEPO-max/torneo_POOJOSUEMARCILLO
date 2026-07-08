using System;
using System.Collections.Generic;
using System.Text;
using torneo_POO.MODELS;

namespace torneo_POO.MODELS
{
    public class Partido
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }



        // Restriccion de encuentros entre el mismo equipo
        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar)

        {
            if (local == visitante || local.Nombre == visitante.Nombre)
            {
                throw new Exception("Error: El equipo local y el visitante no pueden ser el mismo.");
            }
            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;
        }


        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }


        public static Partido RegistrarEncuentroRapido(Equipo local, Equipo visitante, string lugar)
        {
            return new Partido(local, visitante, DateTime.Now, lugar);
        }



        

    }
}




