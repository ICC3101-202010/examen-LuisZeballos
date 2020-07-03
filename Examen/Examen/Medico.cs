using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Medico : Person
    {
        private int experiencia;
        public Medico(string name, int age, string nation, int salary, int experiencia) : base(name, age, nation, salary)
        {

        }
        public void Curar(Jugador jugador)
        {
            jugador.Lesion = false;
        }
        public void Evaluar(List<Jugador> jugadores)
        {
            foreach(Jugador jugador in jugadores)
            {
                if(jugador.Lesion == true)
                {
                    Console.WriteLine("El jugador",jugador.Name, jugador.Numero, "se encuentra lesionado");
                }
            }
        }
    }
}
