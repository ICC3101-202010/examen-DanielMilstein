using System;
namespace Examen
{
    public class Entrenador : Persona
    {
        private int PuntosTactica;

        public Entrenador(string nombre, int edad, string nacion, int sueldo, int tactica) : base(nombre, edad, nacion, sueldo)
        {
            PuntosTactica = tactica;
        }

        public int GetTactica { get { return PuntosTactica; } }

        public void CambiarJugador(Jugador jIn, Jugador jOut)
        {
            return;
        }
    }
}
