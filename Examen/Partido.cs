using System;
namespace Examen
{
    public class Partido
    {
        private Equipo Equipo1;
        private Equipo Equipo2;
        private int Duracion;
        private string Resultado;
        private bool Nacional;
        private bool PartidoValido;

        public Partido(Equipo e1, Equipo e2, int duracion, bool nacional)
        {
            Equipo1 = e1;
            Equipo2 = e2;
            Duracion = duracion;
            Nacional = nacional;
        }

        public Equipo GetEq1 { get { return Equipo1; } }
        public Equipo GetEq2 { get { return Equipo2; } }
        public int GetDuracion { get { return Duracion; } }
        public bool GetNacional { get { return Nacional; } }
        public string GetResultado()
        {
            try
            {
                return Resultado; 
            }
            catch (Exception)
            {
                return "Partido no simulado";
            }

        }

        public void CorroborarEquiposCompatibles()
        {
            bool e1, e2;
            e1 = Equipo1.GetNacional;
            e2 = Equipo2.GetNacional;

            if (Nacional)
            {

                if (e1 == true && e2 == true)
                {
                    PartidoValido = true;
                }
                else
                {
                    PartidoValido = false;
                }
            }
            else
            {
                if (e1 == false && e2 == false)
                {
                    PartidoValido = true;
                }
                else
                {
                    PartidoValido = false;
                }
            }

        }

        public void Simular()
        {
            if (PartidoValido)
            {
                string winner = "";
                Random r = new Random();
                int golesE1, golesE2;

                golesE1 = r.Next(10);
                golesE2 = r.Next(10);
                if (golesE1 > golesE2) { winner = Equipo1.GetNombre; }
                else if (golesE1 < golesE2) { winner = Equipo2.GetNombre; }
                else if (golesE1 == golesE2)
                {
                    Resultado = $"{Equipo1.GetNombre} {golesE1} - {golesE2} {Equipo2.GetNombre}. Empate.";
                    return;
                }

                
                Resultado = $"{Equipo1.GetNombre} {golesE1} - {golesE2} {Equipo2.GetNombre}. Gana equipo {winner}!";
            }
            else
            {
                Resultado = "Partido invalido. Los equipos no pueden ser de una categoria distinta (Nacional/Liga).";
            }
        }

        public void OnPedirCambio()
        {
            //Pausa Simular()
        }
    }
}
