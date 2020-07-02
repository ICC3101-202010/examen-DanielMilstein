using System;
namespace Examen
{
    public abstract class Persona
    {
        protected string Nombre;
        protected int Edad;
        protected string Nacion;
        protected int Sueldo;

        public Persona(string nombre, int edad, string nacion, int sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            Nacion = nacion;
            Sueldo = sueldo;
        }

        public string GetNombre { get { return Nombre; } }
        public int GetEdad { get { return Edad; } }
        public string GetNacion { get { return Nacion; } }
        public int GetSueldo { get { return Sueldo; } }
    }
}
