using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Grafo
    {
        public Vertice lista_primero = null;
        public int[,] ma;
        public int cantidadVertices = 0;//Para saber cuantos vertices tine mi Grafo 

        public Grafo(int c)
        {
            ma = new int[c, c];
            //insertar los nodos(vertices)
            for (int i = 0; i < c; i++)
            {
                string ciudad;
                Console.Write("Ingrese nombre de la ciudad: ");
                ciudad = Console.ReadLine();

                InsertarVertice(ciudad);
            }
        }

        //1. Lista
        //insertar
        public void InsertarVertice(string v)
        {
            //1. Crear espacio de memoria
            Vertice nuevo = new Vertice();
            nuevo.dato = v;

            //caso 1: lista vacia
            if (lista_primero == null)
            {
                lista_primero = nuevo;
            }
            else
            {
                //caso 2: lista no esta vacia
                //ubicar al ultimo
                Vertice temp = lista_primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                //temp=ultimo
                temp.sig = nuevo;
            }
            cantidadVertices++;
        }
        //mostrar
        public void MostrarVertices()
        {
            Vertice temp = lista_primero;
            while (temp != null)
            {
                Console.WriteLine("->" + temp.dato);
                temp = temp.sig;
            }
        }
        //2. Matriz Ady
        public void LlenarMatriz()
        {
            //F|C
            Random r = new Random();
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    ma[i, j] = r.Next(0, 2);
                }
            }
        }
        public void MostrarMatriz()
        {
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    Console.Write(ma[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //3. Propias del grafo
        public void CrearGrafo()
        {
            Random r = new Random();
            //i++ <-equivalente-> temp_i=temp_i.sig;
            Vertice temp_i = lista_primero;
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                Vertice temp_j = lista_primero;
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    if (ma[i, j] == 1)
                    {
                        temp_i.InsertarArista(temp_j,r.Next(100, 999));
                    }

                    temp_j = temp_j.sig;
                }
                temp_i = temp_i.sig;
            }
        }
        /*
                a   b   c   d
             a  0   1   0   1
                1   0   1   0
                0   1   0   1
                1   0   1   0

         */

        public void Recorrer(Vertice v)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Vertice actual: " + v.dato);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Rutas: ");
            v.MostrarAristas();
            int op;
            Console.WriteLine("0-> salir");
            Console.Write("Ingrese un opcion: ");
            op = int.Parse(Console.ReadLine());

            if (op!=0)
            {
                Arista temp = v.lista_aristas;
                for (int i = 0; i < (op - 1); i++)
                {
                    temp = temp.sig;
                }
                Recorrer(temp.destino);
            }

            if (op == 0) Console.WriteLine("Saliendo....");
        }
        public Vertice Buscar(string dato)
        {
            Vertice temp = lista_primero;
            while (temp != null) 
            {
                if (temp.dato == dato) 
                {
                    return temp;
                }
                temp = temp.sig;
            }
            return null;
        }
        public void Dijkstra (string origen, string destino)
        {
            Vertice Vorigen= Buscar(origen);
            Vertice Vdestino=Buscar(destino);
            if (Vorigen == null || Vdestino == null) 
            {
                Console.WriteLine("Vertice origen o destino no esxiste");
            return;
            }
            ListaSimpleDistancias listaDistancias = new ListaSimpleDistancias();
            ListaSimple listaVisitados= new ListaSimple();

            Vertice actual = lista_primero;
            while (actual != null)
            {
                int distanciainicial;
                if (actual == Vorigen)
                {
                    distanciainicial = 0;
                }
                else
                {
                    distanciainicial = int.MaxValue;
                }
                listaDistancias.AgregarDistancias(actual, distanciainicial, null);
                actual = actual.sig;
            }
            while (listaVisitados.cantidadVisitados < cantidadVertices)//Evitar que un vertice se evalue mas de una vez 
            {

            }
        }
        public ListaSimpleDistancias.NodoDistancia ObtenerVisitadosCONmenorditancia(ListaSimpleDistancias listaDistancia,ListaSimple visitados)
        {
            ListaSimpleDistancias.NodoDistancia temp = listaDistancia.PrimerNodo;
            while (temp != null) 
            {
                temp = temp.siguiente;
            }
        }
    }
}
