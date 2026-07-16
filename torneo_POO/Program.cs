
using torneo_POO.MODELS;
using static System.Runtime.InteropServices.JavaScript.JSType;
Jugador objjugador1 = new Jugador("Marcelo", 20, 9, "mediocampo", 30, 2, 5);
Console.WriteLine("jugador creado con exito");
Console.WriteLine("Nombre:" + objjugador1.Nombre);
Console.WriteLine("Edad:" + objjugador1.Edad);
Console.WriteLine("el numero de la camiseta del jugador es:" + objjugador1.Numero);
Console.WriteLine("la posicion en la que juega es:" + objjugador1.Posicion);
Console.WriteLine("los pases que ha dado:" + objjugador1.Pases);
Console.WriteLine("los penales marcados:" + objjugador1.Penalesmarcados);
Console.WriteLine("las asistencias del jugador:" + objjugador1.Asistencias);

Console.WriteLine("-----------------------------------------------------------");

Equipo objequipo1 = new Equipo("España", "Madrid", "Gustavo Costa", 10, "cuatro tres tres");
Console.WriteLine("equipo creado exitosamente");
Console.WriteLine("el equipo:" + objequipo1.Nombre);
Console.WriteLine("la ciudad :" + objequipo1.Ciudad);
Console.WriteLine("directro tecnico de España:" + objequipo1.Directortecnico);
Console.WriteLine("la alineación del equipos será:" + objequipo1.Alineacion);

Console.WriteLine("-----------------------------------------------------------");

Equipo objequipo2 = new Equipo("Francia", "París", "Didier Deschamps", 12, "cuatro cuatro dos");
Console.WriteLine("equipo creado exitosamente");
Console.WriteLine("el equipo:" + objequipo2.Nombre);
Console.WriteLine("la ciudad :" + objequipo2.Ciudad);
Console.WriteLine("directro tecnico de España:" + objequipo2.Directortecnico);
Console.WriteLine("la alineación del equipos será:" + objequipo2.Alineacion);


Console.WriteLine("-----------------------------------------------------------");

Console.WriteLine("=== CONFIGURANDO EQUIPOS ===");

Partido objpartido1 = new Partido(objequipo1, objequipo2, DateTime.Now, "Estadio Monumental", true, "Nestor Pitana", "profesional");

Console.WriteLine("partido creado con exito");
Console.WriteLine("El equipo local es:" + objpartido1.Local.Nombre);
Console.WriteLine("El equipo visitante es:" + objpartido1.Visitante.Nombre);
Console.WriteLine("La fecha del encuentro es:" + objpartido1.Fecha);
Console.WriteLine("El lugar del partido es:" + objpartido1.Lugar);
Console.WriteLine("¿El partido ya se jugo?:" + objpartido1.Partidojugado);
Console.WriteLine("El arbitro del partido es:" + objpartido1.Arbitro);
Console.WriteLine("El tipo de liga es:" + objpartido1.Tipo_deliga);



//Jugador objJugador1 = new Jugador("Messi", 38, 10, "Delantero", 50, 2, 20);

//Jugador objJugador2 = new Jugador("De Paul", 32, 7, "Mediocampo", 40, 1, 5);

//Equipo objEquipo1 = new Equipo("Inter de Miami", "Estados Unidos(florida)");

//objEquipo1.AgregarJugador(objJugador1);
//objEquipo1.AgregarJugador(objJugador2);
//objEquipo1.AgregarJugador(null);



//objEquipo1.ListarPlantilla();

//Jugador objJugador3 = new Jugador("Cristiano Ronaldo", 41, 7, "Delantero", 55, 0, 30);


//Jugador objJugador4 = new Jugador("John Duran", 24, 9, "Delantero", 20, 1, 22);


//Equipo objEquipo2 = new Equipo("AL nassar", "Arabia Saudita (Riad)");


//objEquipo2.AgregarJugador(objJugador3);
//objEquipo2.AgregarJugador(objJugador4);



//objEquipo2.ListarPlantilla();

//Partido objPartido1 = new Partido(objEquipo1, objEquipo2, DateTime.Now, "Miami");
//objPartido1.MostrarResumen();

//// Escenarios de prueba y control de excepciones

//Console.WriteLine("\n--- EJECUTANDO NUEVAS FUNCIONES  ---");
////Probando la nueva función de Jugador
//Console.WriteLine($"Ficha técnica: {objJugador1.ObtenerFichaTecnica()}");

// //Probando la nueva función de Equipo
//if (objEquipo1.TienePlantillaMinima())
//{
//    Console.WriteLine($"El equipo {objEquipo1.Nombre} está apto para competir.");
//}


//Partido objPartidoRapido = Partido.RegistrarEncuentroRapido(objEquipo1, objEquipo2, "Miami");

//objPartidoRapido.MostrarResumen();

//Console.ReadLine();


