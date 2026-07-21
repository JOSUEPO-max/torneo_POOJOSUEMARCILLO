
using torneo_POO.generales;
using torneo_POO.MODELS;
using static System.Runtime.InteropServices.JavaScript.JSType;
int opcion = 0;
Jugador objJug1 = new Jugador("Eduardo", 20, 10, "Delantero", 150, 5, 12);
Jugador objJug2 = new Jugador("Pedro", 30, 11, "Defensa", 300, 0, 4);
Jugador objJug3 = new Jugador("Juan", 25, 1, "Arquero", 50, 0, 1);

database.Jugadores.Add(objJug1);
database.Jugadores.Add(objJug2);
database.Jugadores.Add(objJug3);

do
{
    Console.Clear();
    Console.WriteLine("****************Bienvenido al Torneo de Futbol - ISTLC 2026****************");
    Console.WriteLine("Menú de Opciones:");
    Console.WriteLine("1.- Crear Jugadores");
    Console.WriteLine("2.- Listar Jugadores");
    Console.WriteLine("3.- Buscar Jugador");
    Console.WriteLine("4.- Actualizar Jugador");
    Console.WriteLine("5.- Eliminar Jugador");
    Console.WriteLine("6.- Crear Equipos");
    Console.WriteLine("7.- Listar Equipos");
    Console.WriteLine("8.- Buscar Equipo");
    Console.WriteLine("9.- Actualizar Equipos");
    Console.WriteLine("10.- Eliminar Equipos");
    Console.WriteLine("11.- Crear Partidos");
    Console.WriteLine("12.- Listar Partidos");
    Console.WriteLine("13.- Buscar Partido");
    Console.WriteLine("14.- Actualizar Partido");
    Console.WriteLine("15.- Eliminar Partido");
    Console.WriteLine("16.- Salir");
    Console.WriteLine("");
    Console.Write("Ingrese una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

    switch (opcion)
    {
        case 1: crearJugador(); break;
        case 2: listarJugadores(); break;
        case 3: BuscarJugador(); break;
        case 4: ActualizarJugador(); break;
        case 5: EliminarJugador(); break;
        case 6: crearEquipo(); break;
        case 7: listarEquipos(); break;
        case 8: buscarEquipo(); break;
        case 9: actualizarEquipo(); break;
        case 10: eliminarEquipo(); break;
        case 11: crearPartido(); break;
        case 12: listarPartidos(); break;
        case 13: buscarPartido(); break;
        case 14: actualizarPartido(); break;
        case 15: eliminarPartido(); break;
        case 16:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
            Console.ReadLine();
            break;
    }

} while (opcion != 16);


void crearJugador()
{
    Console.Clear();
    Console.WriteLine("**********Crear Jugador**********");
    try
    {
        Console.Write("Ingrese el nombre del jugador: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la edad del jugador: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el número de la camiseta: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la posición del jugador: ");
        string posicion = Console.ReadLine();
        Console.Write("Ingrese la cantidad de pases (1-1000): ");
        int pases = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese los penales marcados: ");
        int penales = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese las asistencias: ");
        int asistencias = Convert.ToInt32(Console.ReadLine());

        Jugador objJugador = new Jugador(nombre, edad, numero, posicion, pases, penales, asistencias);
        database.Jugadores.Add(objJugador);
        Console.WriteLine("\nJugador creado exitosamente.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nError al crear jugador: {ex.Message}");
    }
    Console.ReadLine();
}

void listarJugadores()
{
    Console.Clear();
    Console.WriteLine("**********Jugadores Creados**********");
    foreach (Jugador jugador in database.Jugadores)
    {
        jugador.Imprimir();
        Console.WriteLine("-----------------------------------");
    }
    Console.ReadLine();
}

void BuscarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Jugador**********");
    Console.Write("Ingrese el nombre del jugador a buscar: ");
    string nombreIngresado = Console.ReadLine();
    Jugador objJugador = database.Jugadores.Find(j => j.Nombre.Equals(nombreIngresado, StringComparison.OrdinalIgnoreCase));
    if (objJugador != null)
    {
        Console.WriteLine("\nJugador encontrado:");
        Console.WriteLine("-----------------------------------");
        objJugador.Imprimir();
    }
    else
    {
        Console.WriteLine("\nJugador no encontrado.");
    }
    Console.ReadLine();
}

void ActualizarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Jugador**********");
    Console.Write("Ingrese el nombre del jugador a actualizar: ");
    string nombreIngresado = Console.ReadLine();
    Jugador objJugador = database.Jugadores.Find(j => j.Nombre.Equals(nombreIngresado, StringComparison.OrdinalIgnoreCase));
    if (objJugador != null)
    {
        try
        {
            Console.WriteLine("\nJugador encontrado:");
            Console.WriteLine("-----------------------------------");
            objJugador.Imprimir();
            Console.WriteLine("-----------------------------------");
            Console.Write("Ingrese el nuevo nombre: ");
            objJugador.Nombre = Console.ReadLine();
            Console.Write("Ingrese la nueva edad: ");
            objJugador.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nuevo número: ");
            objJugador.Numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nueva posición: ");
            objJugador.Posicion = Console.ReadLine();
            Console.Write("Ingrese pases: ");
            objJugador.Pases = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese penales marcados: ");
            objJugador.Penalesmarcados = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese asistencias: ");
            objJugador.Asistencias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nJugador actualizado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError al actualizar: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("\nJugador no encontrado.");
    }
    Console.ReadLine();
}

void EliminarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Jugador**********");
    Console.Write("Ingrese el nombre del jugador a eliminar: ");
    string nombreIngresado = Console.ReadLine();
    Jugador objJugador = database.Jugadores.Find(j => j.Nombre.Equals(nombreIngresado, StringComparison.OrdinalIgnoreCase));
    if (objJugador != null)
    {
        Console.WriteLine("-----------------------------------");
        objJugador.Imprimir();
        Console.WriteLine("-----------------------------------");
        Console.Write($"¿Está seguro de que desea eliminar al jugador {objJugador.Nombre}? (S/N): ");
        if (Console.ReadLine().ToUpper() == "S")
        {
            database.Jugadores.Remove(objJugador);
            Console.WriteLine("\nJugador eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("\nOperación cancelada.");
        }
    }
    else
    {
        Console.WriteLine("\nJugador no encontrado.");
    }
    Console.ReadLine();
}



void crearEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Crear Equipo**********");
    try
    {
        Console.Write("Ingrese el nombre del equipo: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la ciudad del equipo: ");
        string ciudad = Console.ReadLine();
        Console.Write("Ingrese el Director Técnico: ");
        string dt = Console.ReadLine();
        Console.Write("Ingrese la cantidad de suplentes (0-15): ");
        int suplentes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la alineación (ej: cuatro tres tres): ");
        string alineacion = Console.ReadLine();

        Equipo objEquipo = new Equipo(nombre, ciudad, dt, suplentes, alineacion);

        string respuesta = "";
        do
        {
            Console.Write("¿Desea ingresar jugadores al equipo? (S/N): ");
            respuesta = Console.ReadLine().ToUpper();
            if (respuesta == "S")
            {
                Console.Write("Ingrese el nombre del jugador a agregar: ");
                string nombreJugador = Console.ReadLine();
                Jugador objJugador = database.Jugadores.Find(x => x.Nombre.Equals(nombreJugador, StringComparison.OrdinalIgnoreCase));
                if (objJugador != null)
                {
                    objEquipo.AgregarJugador(objJugador);
                }
                else
                {
                    Console.WriteLine("Jugador no encontrado.");
                }
            }
        } while (respuesta == "S");

        database.Equipos.Add(objEquipo);
        Console.WriteLine("\nEquipo creado exitosamente.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nError al crear equipo: {ex.Message}");
    }
    Console.ReadLine();
}

void listarEquipos()
{
    Console.Clear();
    Console.WriteLine("**********Equipos Creados**********");
    foreach (Equipo equipo in database.Equipos)
    {
        Console.WriteLine($"Equipo: {equipo.Nombre} | Ciudad: {equipo.Ciudad} | DT: {equipo.Directortecnico} | Alineación: {equipo.Alineacion}");
        Console.WriteLine("-----------------------------------");
    }
    Console.ReadLine();
}

void buscarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Equipo**********");
    Console.Write("Ingrese el nombre del equipo a buscar: ");
    string nombre_ingresado = Console.ReadLine();
    Equipo objEquipo = database.Equipos.Find(j => j.Nombre.Equals(nombre_ingresado, StringComparison.OrdinalIgnoreCase));
    if (objEquipo != null)
    {
        Console.WriteLine("\nEquipo encontrado:");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Nombre: {objEquipo.Nombre} | Ciudad: {objEquipo.Ciudad} | DT: {objEquipo.Directortecnico}");
        objEquipo.ListarPlantilla();
    }
    else
    {
        Console.WriteLine("\nEquipo no encontrado.");
    }
    Console.ReadLine();
}

void actualizarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Equipo**********");
    Console.Write("Ingrese el nombre del equipo a actualizar: ");
    string nombre_ingresado = Console.ReadLine();
    Equipo objEquipo = database.Equipos.Find(j => j.Nombre.Equals(nombre_ingresado, StringComparison.OrdinalIgnoreCase));

    if (objEquipo != null)
    {
        try
        {
            Console.Write("Ingrese la nueva ciudad: ");
            objEquipo.Ciudad = Console.ReadLine();
            Console.Write("Ingrese el nuevo Director Técnico: ");
            objEquipo.Directortecnico = Console.ReadLine();
            Console.Write("Ingrese la cantidad de suplentes: ");
            objEquipo.Suplentes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nueva alineación: ");
            objEquipo.Alineacion = Console.ReadLine();

            Console.WriteLine("\nEquipo actualizado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError al actualizar: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("\nEquipo no encontrado.");
    }
    Console.ReadLine();
}

void eliminarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Equipo**********");
    Console.Write("Ingrese el nombre del equipo a eliminar: ");
    string nombre_ingresado = Console.ReadLine();
    Equipo objEquipo = database.Equipos.Find(j => j.Nombre.Equals(nombre_ingresado, StringComparison.OrdinalIgnoreCase));

    if (objEquipo != null)
    {
        Console.Write($"¿Está seguro de que desea eliminar el equipo {objEquipo.Nombre}? (S/N): ");
        if (Console.ReadLine().ToUpper() == "S")
        {
            database.Equipos.Remove(objEquipo);
            Console.WriteLine("\nEquipo eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("\nOperación cancelada.");
        }
    }
    else
    {
        Console.WriteLine("\nEquipo no encontrado.");
    }
    Console.ReadLine();
}



void crearPartido()
{
    Console.Clear();
    Console.WriteLine("**********Crear Partido**********");

    if (database.Equipos.Count < 2)
    {
        Console.WriteLine("Error: Se necesitan al menos 2 equipos en la base de datos para crear un partido.");
        Console.ReadLine();
        return;
    }

    try
    {
        Console.Write("Ingrese el nombre del Equipo Local: ");
        string localNombre = Console.ReadLine();
        Equipo eqLocal = database.Equipos.Find(e => e.Nombre.Equals(localNombre, StringComparison.OrdinalIgnoreCase));

        Console.Write("Ingrese el nombre del Equipo Visitante: ");
        string visitanteNombre = Console.ReadLine();
        Equipo eqVisitante = database.Equipos.Find(e => e.Nombre.Equals(visitanteNombre, StringComparison.OrdinalIgnoreCase));

        if (eqLocal == null || eqVisitante == null)
        {
            Console.WriteLine("Error: Uno o ambos equipos no existen.");
            Console.ReadLine();
            return;
        }

        Console.Write("Ingrese el lugar del encuentro: ");
        string lugar = Console.ReadLine();
        Console.Write("Ingrese el nombre del árbitro: ");
        string arbitro = Console.ReadLine();
        Console.Write("Ingrese el tipo de liga: ");
        string tipoLiga = Console.ReadLine();
        Console.Write("¿El partido ya se jugó? (S/N): ");
        bool jugado = Console.ReadLine().ToUpper() == "S";

        Partido nuevoPartido = new Partido(eqLocal, eqVisitante, DateTime.Now, lugar, jugado, arbitro, tipoLiga);
        database.Partidos.Add(nuevoPartido);

        Console.WriteLine("\nPartido registrado con éxito.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nError al registrar el partido: {ex.Message}");
    }
    Console.ReadLine();
}

void listarPartidos()
{
    Console.Clear();
    Console.WriteLine("**********Partidos Registrados**********");
    if (database.Partidos.Count == 0)
    {
        Console.WriteLine("No hay partidos programados.");
    }
    else
    {
        foreach (Partido p in database.Partidos)
        {
            p.MostrarResumen();
            Console.WriteLine("-----------------------------------");
        }
    }
    Console.ReadLine();
}

void buscarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Partido**********");
    Console.Write("Ingrese el nombre del equipo (local o visitante): ");
    string busqueda = Console.ReadLine();

    Partido p = database.Partidos.Find(p =>
        p.Local.Nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
        p.Visitante.Nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

    if (p != null)
    {
        Console.WriteLine("\nPartido encontrado:");
        p.MostrarResumen();
    }
    else
    {
        Console.WriteLine("\nNo se encontró un partido con ese equipo.");
    }
    Console.ReadLine();
}

void actualizarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Partido**********");
    Console.Write("Ingrese el nombre del Equipo Local del partido a actualizar: ");
    string localNombre = Console.ReadLine();

    Partido p = database.Partidos.Find(p => p.Local.Nombre.Equals(localNombre, StringComparison.OrdinalIgnoreCase));

    if (p != null)
    {
        try
        {
            Console.Write("Ingrese el nuevo lugar: ");
            p.Lugar = Console.ReadLine();
            Console.Write("Ingrese el nuevo árbitro: ");
            p.Arbitro = Console.ReadLine();
            Console.Write("Ingrese el nuevo tipo de liga: ");
            p.Tipo_deliga = Console.ReadLine();
            Console.Write("¿El partido ya se jugó? (S/N): ");
            p.Partidojugado = Console.ReadLine().ToUpper() == "S";

            Console.WriteLine("\nPartido actualizado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError al actualizar: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("\nPartido no encontrado.");
    }
    Console.ReadLine();
}

void eliminarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Partido**********");
    Console.Write("Ingrese el nombre del Equipo Local del partido a eliminar: ");
    string localNombre = Console.ReadLine();

    Partido p = database.Partidos.Find(p => p.Local.Nombre.Equals(localNombre, StringComparison.OrdinalIgnoreCase));

    if (p != null)
    {
        p.MostrarResumen();
        Console.Write("¿Está seguro de eliminar este partido? (S/N): ");
        if (Console.ReadLine().ToUpper() == "S")
        {
            database.Partidos.Remove(p);
            Console.WriteLine("\nPartido eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("\nOperación cancelada.");
        }
    }
    else
    {
        Console.WriteLine("\nPartido no encontrado.");
    }
    Console.ReadLine();
}







//Jugador objjugador1 = new Jugador("Marcelo", 20, 9, "mediocampo", 30, 2, 5);
//Console.WriteLine("jugador creado con exito");
//Console.WriteLine("Nombre:" + objjugador1.Nombre);
//Console.WriteLine("Edad:" + objjugador1.Edad);
//Console.WriteLine("el numero de la camiseta del jugador es:" + objjugador1.Numero);
//Console.WriteLine("la posicion en la que juega es:" + objjugador1.Posicion);
//Console.WriteLine("los pases que ha dado:" + objjugador1.Pases);
//Console.WriteLine("los penales marcados:" + objjugador1.Penalesmarcados);
//Console.WriteLine("las asistencias del jugador:" + objjugador1.Asistencias);

//Console.WriteLine("-----------------------------------------------------------");

//Equipo objequipo1 = new Equipo("España", "Madrid", "Gustavo Costa", 10, "cuatro tres tres");
//Console.WriteLine("equipo creado exitosamente");
//Console.WriteLine("el equipo:" + objequipo1.Nombre);
//Console.WriteLine("la ciudad :" + objequipo1.Ciudad);
//Console.WriteLine("directro tecnico de España:" + objequipo1.Directortecnico);
//Console.WriteLine("la alineación del equipos será:" + objequipo1.Alineacion);

//Console.WriteLine("-----------------------------------------------------------");

//Equipo objequipo2 = new Equipo("Francia", "París", "Didier Deschamps", 12, "cuatro cuatro dos");
//Console.WriteLine("equipo creado exitosamente");
//Console.WriteLine("el equipo:" + objequipo2.Nombre);
//Console.WriteLine("la ciudad :" + objequipo2.Ciudad);
//Console.WriteLine("directro tecnico de España:" + objequipo2.Directortecnico);
//Console.WriteLine("la alineación del equipos será:" + objequipo2.Alineacion);


//Console.WriteLine("-----------------------------------------------------------");

//Console.WriteLine("=== CONFIGURANDO EQUIPOS ===");

//Partido objpartido1 = new Partido(objequipo1, objequipo2, DateTime.Now, "Estadio Monumental", true, "Nestor Pitana", "profesional");

//Console.WriteLine("partido creado con exito");
//Console.WriteLine("El equipo local es:" + objpartido1.Local.Nombre);
//Console.WriteLine("El equipo visitante es:" + objpartido1.Visitante.Nombre);
//Console.WriteLine("La fecha del encuentro es:" + objpartido1.Fecha);
//Console.WriteLine("El lugar del partido es:" + objpartido1.Lugar);
//Console.WriteLine("¿El partido ya se jugo?:" + objpartido1.Partidojugado);
//Console.WriteLine("El arbitro del partido es:" + objpartido1.Arbitro);
//Console.WriteLine("El tipo de liga es:" + objpartido1.Tipo_deliga);



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


