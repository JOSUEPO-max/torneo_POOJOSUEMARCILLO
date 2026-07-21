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


Gestión de Jugadores (Opciones 1 - 5)
* **Crear Jugador:** Registro con validaciones de edad mínima ($edad \ge 18$) y dorsales válidos.
* **Listar Jugadores:** Muestra toda la plantilla disponible en el sistema.
* **Buscar Jugador:** Búsqueda individual por nombre (insensible a mayúsculas/minúsculas).
* **Actualizar Jugador:** Modificación de atributos (edad, dorsal, posición, estadísticas).
* **Eliminar Jugador:** Remoción segura con confirmación del usuario.

### Gestión de Equipos (Opciones 6 - 10)
* **Crear Equipo:** Registro de datos principales y asignación directa de jugadores existentes.
* **Listar Equipos:** Muestra los equipos registrados junto con sus datos generales.
* **Buscar Equipo:** Consulta de equipo y despliegue de su plantilla de jugadores.
* **Actualizar Equipos:** Edición de ciudad, Director Técnico, suplentes y alineación táctica.
* **Eliminar Equipos:** Eliminación de registros de la base de datos previa confirmación.

###  Gestión de Partidos (Opciones 11 - 15)
* **Crear Partidos:** Programación de encuentros validando la existencia de al menos dos equipos distintos.
* **Listar Partidos:** Despliegue de partidos programados y jugados con detalles del encuentro.
* **Buscar Partido:** Búsqueda por el nombre de cualquiera de los equipos involucrados (local o visitante).
* **Actualizar Partido:** Cambio de sede, árbitro, tipo de liga y estado del encuentro (jugado/no jugado).
* **Eliminar Partido:** Remoción de encuentros del calendario.
