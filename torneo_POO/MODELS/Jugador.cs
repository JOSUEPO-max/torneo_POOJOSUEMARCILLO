using System;
using System.Collections.Generic;
using System.Text;

namespace torneo_POO.MODELS
{
    public class Jugador
    {

        private string nombre
;       private int edad;
        private int numero;
        private string posicion;
        private int pases;
        private int penalesmarcados;
        private int asistencias; 

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public int Pases 
        { 
            get => pases; 
            set
            {
                if (value <= 0 || value <= 1000)
                {
                    throw new Exception("Los pases deben estar entre 1 y 1000.");
                }
                pases = value;
            }
        }
        public int Penalesmarcados 
        {
            get => penalesmarcados;
            set
            {
                if (value <= 0 || value <= 1000)
                {
                    throw new Exception("Los penales marcados deben estar entre 1 y 1000. ");
                }
                penalesmarcados = value;
            }
        }
        public int Asistencias 
        { 
            get => asistencias; 
            set
            {
                if (value <= 0 || value <= 1000)
                {
                    throw new Exception("Las asistencias deben estar entre 1 y 1000.");
                }
                asistencias = value;
            }
        }


        //Constructor
        public Jugador(string nombre, int edad, int numero, string posicion, int pases, int penalesmarcados, int asistencias)
        {
            if (!EsMayorEdad(edad))
            {
                throw new Exception("El jugador debe ser mayor de edad");
            }
            if (!EsNumeroValido(numero))
            {
                throw new Exception("El número de la camiseta no es válido");
            }

            this.Nombre = nombre;
            this.Edad = edad;
            this.Numero = numero;
            this.Posicion = posicion;
            this.pases = pases;
            this.penalesmarcados = penalesmarcados;
            this.asistencias = asistencias;
        }


        public void Presentar()
        {
            Console.WriteLine($"Hola soy {this.Nombre} tengo {this.Edad} años y mi número es el {this.Numero}");
        }



        public Boolean EsMayorEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EsNumeroValido(int numero)
        {
            if (numero > 0 && numero < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string ObtenerFichaTecnica()
        {
            return $"[{Posicion.ToUpper()}] #{Numero} - {Nombre} ({Edad} años)";
        }

    }
}
    
