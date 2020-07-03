using System;
namespace Examen
{
    public class LesionEventArgs : EventArgs
    {
        public Entrenador Coach { get; set; }
        public Equipo Team { get; set; }
        public Partido Match { get; set; }
        
    }
}
