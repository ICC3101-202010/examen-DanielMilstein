using System;
namespace Examen
{
    public class Medico : Persona
    {
        private int Experiencia;

        public Medico(string nombre, int edad, string nacion, int sueldo, int exp) : base(nombre, edad, nacion, sueldo)
        {
            Experiencia = exp;
        }

        public int GetExperiencia { get { return Experiencia; } }

        public void Evaluar(Jugador j)
        {
            return;
        }
        public void Curar(Jugador j)
        {
            return;
        }

    }
}
