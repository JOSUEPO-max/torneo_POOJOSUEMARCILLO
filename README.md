2026-07-02 Mi primera clase

2026-07-07 Comportamientos de las clases Creación de métodos Creación de constructores Validación de datos

2026-07-08

 Funcionalidades Añadidas
 Nuevos Métodos Implementados:
* **Jugador**: Método para obtener la ficha técnica formateada del jugador.
* **Equipo**: Validación para verificar si el equipo cuenta con la plantilla mínima para competir.
* **Partido**: Creación simplificada de encuentros rápidos utilizando la fecha actual del sistema.
 Reglas de Validación del Sistema:
* **Validación de Camisetas**: Restricción para asegurar que el número del jugador sea válido (mayor a 0 y menor a 100).
* **Validación de Partidos / Equipos**: Control de consistencia en el flujo de los datos ingresados al sistema deportivos con mensajes de error claros.

  
Validaciones Implementadas
Jugadores: Las estadísticas de pases, penales y asistencias solo aceptan valores entre 1 y 1000.
Equipos:
El nombre del Director Técnico no puede estar vacío.
Los suplentes están limitados estrictamente entre 0 y 15.
La alineación solo acepta texto específico en palabras (ej: "cuatro tres tres", "cuatro cuatro dos").
Partidos: Unifica al equipo local y visitante. Valida que los campos de Árbitro y Tipo de liga no se envíen vacíos, y maneja el estado del juego con un booleano (true/false).
 Ejecución (Program.cs)
El programa principal crea los objetos de los equipos (ej: España y Francia), inicializa el partido con su fecha y estadio, y muestra toda la información ordenada línea por línea en la consola.
