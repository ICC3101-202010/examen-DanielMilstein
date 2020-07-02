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
            if (Nacional) { tipo = "Equipo Nacional."; }
            else { tipo = "Equipo de Liga."; }

            Console.WriteLine(tipo);
            Console.WriteLine($"Entrenador: {Coach}");
            Console.WriteLine($"Medico: {Medic}");
            Console.WriteLine("JUGADORES");

            if (Jugadores.Count > 0)
            {
                foreach (Jugador item in Jugadores)
                {
                    Console.WriteLine($"");
                }
            }
        }
    }
}
