using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Equipo
    {
        private string name;
        private List<Jugador> jugadores;
        private Entrenador entrenador;
        private Medico medico;
        private string type;        // nacional o liga
        private string nation;      //Todos los equipos(nacional o liga)pertenecen a un pais

        public Equipo(string name, List<Jugador> jugadores, Entrenador entrenador, Medico medico, string type)
        {
            if (type == "nacional")
            {
                foreach (Jugador jugador in jugadores)
                {
                    if (jugador.Nation == nation)
                    {
                        Console.WriteLine("El jugador:", jugador.Name,"no comple con la nacionalidad para jugar en el equipo");
                    }
                    else
                    {
                        this.jugadores = jugadores;
                        this.entrenador = entrenador;
                        this.medico = medico;
                        this.type = type;
                    }
                }
            }
        }

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }

        public void AgregarJugador(Jugador jugador)
        {
            if(this.jugadores.Count < 15)
            {
                this.jugadores.Add(jugador);
            }
            else
            {
                Console.WriteLine("El equipo ya tiene su máximo de jugadores");
            }
        }
        public void CambiarEntrenador(Entrenador entrenador)
        {
            this.entrenador = entrenador;
        }
        public void CambiarMedico(Medico medico)
        {
            this.medico = medico;
        }

        public void InfoEquipo()
        {
            Console.WriteLine("Nombre equipo:",Name);
            Console.WriteLine("Del tipo:",type);
            Console.WriteLine("Conformado por:\n");
            Console.WriteLine("Entrenador:",entrenador);
            Console.WriteLine("Medico:",medico);
            Console.WriteLine("Plantilla:");
            foreach(Jugador jugador in jugadores)
            {
                Console.WriteLine(jugador.Name,jugador.Numero);
            }
        }


    }
}
