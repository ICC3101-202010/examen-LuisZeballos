using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Partido
    {
        private string resultado;
        private string type;
        private int duracion;
        private Equipo Equipo1;
        private Equipo Equipo2;

        public Partido(string type, int duracion, Equipo equipo1, Equipo equipo2)
        {
            this.resultado = null;
            this.type = type;
            this.duracion = duracion;
            Equipo1 = equipo1;
            Equipo2 = equipo2;
        }

        public string Resultado { get => resultado; set => resultado = value; }
        public string Type { get => type; set => type = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public Equipo Equipo11 { get => Equipo1; set => Equipo1 = value; }
        public Equipo Equipo21 { get => Equipo2; set => Equipo2 = value; }

        public bool Enfrentamiento()   //Ver si puede jugar contra el otro equipo
        {
            if (Equipo1.Type == this.Type && Equipo2.Type == this.Type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SimularPartido()
        {

        }
        public void RealizarCambio(Equipo equipo)
        {
            equipo.Entrenador.CambiarJugador();
        }
    }
}
