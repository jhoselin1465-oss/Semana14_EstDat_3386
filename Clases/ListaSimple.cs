using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaSimple
    {
        public Vertice PrimerVertice = null;
        public int cantidadVisitados = 0;
        public void AgregarVisitado(Vertice v) //insertar Ls
        {
            Vertice nuevoVertice = new Vertice();
            nuevoVertice.dato = v.dato;
            nuevoVertice.lista_aristas = v.lista_aristas;
            if (PrimerVertice == null)
            {
                PrimerVertice = nuevoVertice;
            }
            else
            {
                Vertice temp = PrimerVertice;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevoVertice;
            }
            cantidadVisitados++;//visitando
        }
        public bool buscarVisitados(Vertice v) //BuscarVisitados o Contiene
        {
            Vertice temp = PrimerVertice;
            while (temp != null)
            {
                if (temp.dato == v.dato) //encontre, ya fue visitado!
                {
                    return true;
                }
                temp = temp.sig;
            }
            return false;
        }
    }

    public class ListaSimpleDistancias
    {
        public class NodoDistancia
        {
            public Vertice vertice;
            public int costo;
            public Vertice Previo;
            public NodoDistancia siguiente = null;
        }

        public NodoDistancia PrimerNodo = null;
        public int cantidadnodos = 0;
        public void AgregarDistancias(Vertice v, int costo, Vertice previo) //insertar Ls
        {
            NodoDistancia nuevoNodo = new NodoDistancia();
            nuevoNodo.vertice = v;
            nuevoNodo.costo = costo;
            nuevoNodo.Previo = previo;
            if (PrimerNodo == null)
            {
                PrimerNodo = nuevoNodo;
            }
            else
            {
                NodoDistancia temp = PrimerNodo;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoNodo;
            }
            cantidadnodos++;//faltan determinar sus distancias
        }
        public NodoDistancia obtenerNodo(Vertice v) //Encontrar buscar
        {
            NodoDistancia temp = PrimerNodo;
            while (temp != null)
            {
                if (temp.vertice == v) //encontre, ya fue visitado!
                {
                    return temp;
                }
                temp = temp.siguiente;
            }
            return null;
        }
    }


}

