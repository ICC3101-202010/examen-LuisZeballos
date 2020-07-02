using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Jugador : Person
    {
        private int ataque;
        private int defensa;
        private int numero;
        private string posicion;
        private bool lesion;
        public Jugador(string name, int age, string nation, int salary, int ataque, int defensa, int numero, string posicion) : base(name, age, nation, salary)
        {
            this.lesion = false;
        }

        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public bool Lesion { get => lesion; set => lesion = value; }
    }
}
