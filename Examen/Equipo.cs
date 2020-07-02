using System;
using System.Collections.Generic;

namespace Examen
{
    public class Equipo
    {
        private string Nombre;
        private bool Nacional;  //true-> Equipo nacional false-> Liga
        private List<Jugador> Jugadores;
        private Entrenador Coach;
        private Medico Medic;

        public Equipo(string nombre, bool nacional)
        {
            Nombre = nombre;
            Nacional = nacional;
            Jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, bool nacional, Entrenador coach) : this(nombre, nacional)
        {
            Coach = coach;
        }

        public Equipo(string nombre, bool nacional, Medico medic) : this(nombre, nacional)
        {
            Medic = medic;
        }

        public Equipo(string nombre, bool nacional, Entrenador coach, Medico medic) : this(nombre, nacional, coach)
        {
            Medic = medic;
        }
        public string GetNombre { get { return Nombre; } }
        public bool GetNacional { get { return Nacional; } }

        public void AddJugador(Jugador j)
        {
            if (Jugadores.Count == 15)
            {
                Console.WriteLine("Equipo ya contiene el maximo de jugadores permitidos.");
                return;
            }
            Random r = new Random();
            if (JugadorValido(j))
            {
                int camiseta;
                try
                {
                    camiseta = j.GetNdeCamiseta;
                }
                catch (Exception)
                {
                    camiseta = r.Next(1, 100);
                }

                if (Jugadores.Count == 0)
                {
                    j.SetNdeCamiseta = camiseta;
                    Jugadores.Add(j);
                }
                else
                {
                    bool valido = false;
                    while (valido == false)
                    {
                        bool existe = false;
                        foreach (Jugador item in Jugadores)
                        {
                            if (item.GetNdeCamiseta == camiseta)
                            {
                                existe = true;
                            }
                        }

                        if (existe)
                        {
                            camiseta = r.Next(1, 100);
                        }
                        else { valido = true; }
                    }

                    j.SetNdeCamiseta = camiseta;
                    Jugadores.Add(j);
                }
            }
        }

        public void RemoveJugador(Jugador j)
        {
            if (Jugadores.Contains(j))
            {
                Jugadores.Remove(j);
            }
            else
            {
                Console.WriteLine($"El equipo {Nombre} no tiene a {j.GetNombre} como jugador.");
            }
        }

        public bool JugadorValido(Jugador j)
        {
            if (Nacional)
            {
                if (Nombre.ToLower() == j.GetNacion.ToLower())
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return true;
            }
        }

        public void PrintEquipo()
        {
            Console.WriteLine($"Nombre del equipo: {Nombre}.");

            string tipo;
            if (Nacional) { tipo = $"Equipo Nacional de {Nombre}."; }
            else { tipo = "Equipo de Liga."; }

            Console.WriteLine(tipo);
            Console.WriteLine($"Entrenador: {Coach}, {Coach.GetTactica} puntos de tactica.");
            Console.WriteLine($"Medico: {Medic}, {Medic.GetExperiencia} puntos de experiencia.");
            Console.WriteLine("JUGADORES");
            Console.WriteLine();
            string arg0, arg1, arg2, arg3, arg4, arg5, arg6;
            arg0 = "N˚";
            arg1 = "Nombre"; 
            arg2 = "Edad";
            arg3 = "Nacion";
            arg4 = "Sueldo";
            arg5 = "Ataque";
            arg6 = "Defensa";

            Console.WriteLine(String.Format("|{0,2}|{1,15}|{2,5}|{3,10}|{4,10}|{5,6}|{6,7}|", arg0, arg1, arg2, arg3, arg4, arg5, arg6));
            if (Jugadores.Count > 0)
            {
                foreach (Jugador item in Jugadores)
                {
                    arg0 = item.GetNdeCamiseta.ToString();
                    arg1 = item.GetNombre;
                    arg2 = item.GetEdad.ToString();
                    arg3 = item.GetNacion;
                    arg4 =  $"${item.GetSueldo}";
                    arg5 = item.GetAtaque.ToString();
                    arg6 = item.GetDefensa.ToString();
                    Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|", arg0, arg1, arg2, arg3, arg4, arg5, arg6));
                }
            }
        }
    }
}
