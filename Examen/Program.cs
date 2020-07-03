using System;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Entrenador entrenador = new Entrenador("Marcelo", 56, "Argentina", 15000000, 96);
            Medico medic = new Medico("Marcela", 36, "Chile", 12000000, 99);
            Equipo eq = new Equipo("Chile", true, entrenador, medic);
            Jugador j1 = new Jugador("Alexis", 31, "chile", 30000000, 92, 86, 7);
            Jugador j2 = new Jugador("Leo", 32, "argentina", 40000000, 98, 90, 11);

            j1.Lesionado += entrenador.OnLesionado;



            eq.AddJugador(j1);
            eq.AddJugador(j2);
            eq.PrintEquipo();

            Console.WriteLine();

            Entrenador entrenador2 = new Entrenador("Jorge", 52, "Argentina", 16000000, 98);
            Medico medic2 = new Medico("Javiera", 33, "Chile", 12000000, 97);
            Equipo eq2 = new Equipo("Barcelona 2011", false, entrenador2, medic2);
            

            eq2.AddJugador(j1);
            eq2.AddJugador(j2);
            eq2.PrintEquipo();
            
            
        }

        private static void J1_Lesionado(object sender, LesionEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
