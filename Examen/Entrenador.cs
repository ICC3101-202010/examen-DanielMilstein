using System;
using System.Collections.Generic;

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

        public void OnLesionado(object sender, LesionEventArgs args)
        {
            OnPedirCambio();

            Random r = new Random();
            Jugador j = (Jugador)sender;
            List<Jugador> lista = args.Team.GetJugadores;
            lista.Remove(j);
            int nLista = lista.Count;
            int nJugador = r.Next(1, nLista);
            Jugador j2 = lista[nJugador];


            CambiarJugador(j, j2);
        }

        public event EventHandler PedirCambio;

        protected virtual void OnPedirCambio()
        {
            if (PedirCambio != null)
            {
                PedirCambio(this, EventArgs.Empty);
            }
                
        }
    }
}
