using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    internal class Grafo
    {
        public List<Nodo> Nodos { get; set; } = new List<Nodo>();

        public void AgregarNodo(string nombre)
        {
            if (Nodos.Exists(n => n.Nombre == nombre)) return;
            Nodos.Add(new Nodo(nombre));
        }

        public void ConectarNodos(string origen, string destino)
        {
            Nodo nodoOrigen = Nodos.Find(n => n.Nombre == origen);
            Nodo nodoDestino = Nodos.Find(n => n.Nombre == destino);

            if (nodoOrigen != null && nodoDestino != null && !nodoOrigen.Vecinos.Contains(nodoDestino))
            {
                nodoOrigen.Vecinos.Add(nodoDestino);
                nodoDestino.Vecinos.Add(nodoOrigen); // Conexión bidireccional
            }
        }

        public string MostrarGrafo()
        {
            string resultado = "";
            foreach (var nodo in Nodos)
            {
                resultado += $"{nodo.Nombre}: ";
                foreach (var vecino in nodo.Vecinos)
                {
                    resultado += $"{vecino.Nombre} ";
                }
                resultado += "\n";
            }
            return resultado;
        }

    }
}
