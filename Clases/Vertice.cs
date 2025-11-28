using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //VERTICE ES LO MISMO QUE EL NODOOOOOOOOOO
    public class Vertice
    {
        public string dato;//nombre ciudad
        //config. para lista
        public Vertice sig = null;

        //config. para grafo
        public Arista lista_aristas = null;//primero

        public void InsertarArista(Vertice destino, int costo)
        {
            //1. Crear espacio de memoria
            Arista nuevo = new Arista();
            nuevo.destino = destino;
            nuevo.costo = costo;

            //caso 1: lista vacia
            if (lista_aristas == null)
            {
                lista_aristas = nuevo;
            }
            else
            {
                //caso 2: lista no esta vacia
                //ubicar al ultimo
                Arista temp = lista_aristas;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                //temp=ultimo
                temp.sig = nuevo;
            }
        }
        //mostrar
        public void MostrarAristas()
        {
            Arista temp = lista_aristas;
            int i = 1;
            while (temp != null)
            {
                Console.WriteLine("->"+i+". " + temp.destino.dato+":s/."+temp.costo);
                temp = temp.sig;
                i++;
            }
        }
    }
}
