
using torneo_POO.MODELS;


Jugador objJugador1 = new Jugador("Messi", 38, 10, "Delantero");

Jugador objJugador2 = new Jugador("De Paul", 32, 7, "Mediocampo");

Equipo objEquipo1 = new Equipo("Inter de Miami", "Estados Unidos(florida)");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);
objEquipo1.AgregarJugador(null);



objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador("Cristiano Ronaldo", 41, 7, "Delantero");


Jugador objJugador4 = new Jugador("John Duran", 24, 9, "Delantero");


Equipo objEquipo2 = new Equipo("AL nassar", "Arabia Saudita (Riad)");


objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);


  
objEquipo2.ListarPlantilla();

Partido objPartido1 = new Partido(objEquipo1, objEquipo2, DateTime.Now, "Miami");
objPartido1.MostrarResumen();

// Escenarios de prueba y control de excepciones

Console.WriteLine("\n--- EJECUTANDO NUEVAS FUNCIONES  ---");
//Probando la nueva función de Jugador
Console.WriteLine($"Ficha técnica: {objJugador1.ObtenerFichaTecnica()}");

 //Probando la nueva función de Equipo
if (objEquipo1.TienePlantillaMinima())
{
    Console.WriteLine($"El equipo {objEquipo1.Nombre} está apto para competir.");
}


Partido objPartidoRapido = Partido.RegistrarEncuentroRapido(objEquipo1, objEquipo2, "Miami");

objPartidoRapido.MostrarResumen();

Console.ReadLine();


