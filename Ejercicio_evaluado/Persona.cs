using System;

namespace Ejercicio_evaluado
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;

        public Persona(string nombre, string apellido , int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;

        }
    }
}
