using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    internal class Nodo
    {
        public string Nombre { get; set; }
        public List<Nodo> Vecinos { get; set; } = new List<Nodo>();

        public Nodo(string nombre)
        {
            Nombre = nombre;
        }
    }
}
