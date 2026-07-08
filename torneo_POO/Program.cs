
using TorneoPOO_JOSMARCILLO.MODELS;

Jugador objJugador1 = new Jugador();

objJugador1.Nombre = "Messi";
objJugador1.Numero = 10;
objJugador1.Posicion = "Delantero";
objJugador1.Edad = 38;

objJugador1.Presentar();

Jugador objJugador2 = new Jugador();

objJugador2.Nombre = "De Paul";
objJugador2.Numero = 7;
objJugador2.Posicion = "mediocampo";
objJugador2.Edad = 32;

objJugador2.Presentar();
Equipo objEquipo1 = new Equipo();

objEquipo1.Nombre = "Inter de Miami";
objEquipo1.Ciudad = "Estados Unidos(florida)";
objEquipo1.Jugadores = new List<Jugador>();

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);



objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador();

objJugador3.Nombre = "Cristiano Ronaldo";
objJugador3.Numero = 7;
objJugador3.Posicion = "delantero";
objJugador3.Edad = 41;


Jugador objJugador4 = new Jugador();

objJugador4.Nombre = "John Duran";
objJugador4.Numero = 9;
objJugador4.Posicion = "delantero";
objJugador4.Edad = 22;


Equipo objEquipo2 = new Equipo();

objEquipo2.Nombre = "AL nassar";
objEquipo2.Ciudad = "Arabia Saudita (Riad)";
objEquipo2.Jugadores = new List<Jugador>();

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1 = new Partido();
objPartido1.Programar(objEquipo1, objEquipo2, DateTime.Now, "");
objPartido1.MostrarResumen();