
using torneo_POO.MODELS;


Jugador objJugador1 = new Jugador("Messi", 38, 10, "Delantero");

Jugador objJugador2 = new Jugador("De Paul", 32, 7, "Mediocampo");

Equipo objEquipo1 = new Equipo("Inter de Miami", "Estados Unidos(florida)");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);



objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador("Cristiano Ronaldo", 41, 7, "Delantero");


Jugador objJugador4 = new Jugador("John Duran", 22, 9, "Delantero");


Equipo objEquipo2 = new Equipo("AL nassar", "Arabia Saudita (Riad)");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1 = new Partido(objEquipo1, objEquipo2, DateTime.Now, "Miami");
objPartido1.MostrarResumen();



Console.WriteLine("\n--- EJECUTANDO NUEVAS FUNCIONES  ---");
// 1. Probando la nueva función de Jugador
Console.WriteLine($"Ficha técnica: {objJugador1.ObtenerFichaTecnica()}");

// 2. Probando la nueva función de Equipo
if (objEquipo1.TienePlantillaMinima())
{
    Console.WriteLine($"El equipo {objEquipo1.Nombre} está apto para competir.");
}

// 3. Probando la nueva función de Partido (Creación simplificada)
// Línea 49
Partido objPartidoRapido = Partido.RegistrarEncuentroRapido(objEquipo1, objEquipo2, "Miami");
// Línea 50
objPartidoRapido.MostrarResumen();

Console.ReadLine();