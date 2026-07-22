using System;
using System.Collections.Generic;
using System.Text;
using torneo_POO.MODELS;

namespace torneo_POO.generales
{
    public static class database

    {
        private static readonly string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
        private static readonly string rutaArchivoJugadores = Path.Combine(rutaCarpeta, "jugadores.json");
        private static readonly string rutaArchivoEquipos = Path.Combine(rutaCarpeta, "equipos.json");
        private static readonly string rutaArchivoPartidos = Path.Combine(rutaCarpeta, "partidos.json");

        public static List<Jugador> Jugadores = new List<Jugador>();
        public static List<Equipo> Equipos = new List<Equipo>();
        public static List<Partido> Partidos = new List<Partido>();

        public static void CargarDatos()
        {
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            Jugadores = ArchivoJson.Cargar<Jugador>(rutaArchivoJugadores);
            Equipos = ArchivoJson.Cargar<Equipo>(rutaArchivoEquipos);
            Partidos = ArchivoJson.Cargar<Partido>(rutaArchivoPartidos);
        }

        public static void GuardarDatos()
        {
            ArchivoJson.Guardar(rutaArchivoJugadores, Jugadores);
            ArchivoJson.Guardar(rutaArchivoEquipos, Equipos);
            ArchivoJson.Guardar(rutaArchivoPartidos, Partidos);
        }

        public static void GuardarJugadores()
        {
            ArchivoJson.Guardar(rutaArchivoJugadores, Jugadores);
        }
        public static void GuardarEquipos()
        {
            ArchivoJson.Guardar(rutaArchivoEquipos, Equipos);
        }
        public static void GuardarPartidos()
        {
            ArchivoJson.Guardar(rutaArchivoPartidos, Partidos);
        }




    }
}
