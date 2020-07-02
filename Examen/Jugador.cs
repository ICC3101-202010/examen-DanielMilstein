using System;
namespace Examen
{
    public class Jugador : Persona
    {
        private int NdeCamiseta; //Numero entre 1 y 99.
        private int PuntosAtaque;
        private int PuntosDefensa;

        public Jugador(string nombre, int edad, string nacion, int sueldo, int ataque, int defensa) : base(nombre, edad, nacion, sueldo)
        {
            PuntosAtaque = ataque;
            PuntosDefensa = defensa;
        }

        public Jugador(string nombre, int edad, string nacion, int sueldo, int ataque, int defensa, int camiseta) : this(nombre, edad, nacion, sueldo, ataque, defensa)
        {
            NdeCamiseta = camiseta;
        }

        public int GetNdeCamiseta {get {return NdeCamiseta;} }
        public int SetNdeCamiseta { set => NdeCamiseta = value; }
        public int GetAtaque { get { return PuntosAtaque; } }
        public int GetDefensa { get { return PuntosDefensa; } }

        public void JugarEnCancha()
        {
            return;
        }


    }
}
