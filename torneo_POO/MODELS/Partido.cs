using System;
using System.Collections.Generic;
using System.Text;
using torneo_POO.MODELS;

namespace torneo_POO.MODELS
{
    public class Partido
    {
        private Equipo local;
        private Equipo visitante;
        private DateTime fecha;
        private string lugar;
        private bool partidojugado;
        private string  arbitro;
        private string tipo_deliga;

        public Equipo Local { get => local; set => local = value; }
        public Equipo Visitante { get => visitante; set => visitante = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public bool Partidojugado 
        { 
            get => partidojugado;       
            set
            {
               partidojugado = value;
            }
        }
        public string Arbitro 
        { 
            get => arbitro; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre del árbitro no puede estar vacío.");
                }
                arbitro = value;
            }
        }
        public string Tipo_deliga 
        { 
            get => tipo_deliga; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El tipo de liga no puede estar vacio no puede estar vacío.");
                }
                tipo_deliga = value;
            }
        }



        // Restriccion de encuentros entre el mismo equipo
        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar, bool partidojugado, string arbitro, string tipo_deliga)

        {
            if (local == visitante || local.Nombre == visitante.Nombre)
            {
                throw new Exception("Error: El equipo local y el visitante no pueden ser el mismo.");
            }
            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;
            this.Partidojugado = partidojugado;
            this.Arbitro = arbitro;
            this.Tipo_deliga = tipo_deliga;
        }


        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }


        public static Partido RegistrarEncuentroRapido(Equipo local, Equipo visitante, string lugar, bool partidojugado, string arbitro, string tipo_deliga)
        {
            return new Partido(local, visitante, DateTime.Now, lugar, partidojugado, arbitro, tipo_deliga);
        }



        

    }
}




