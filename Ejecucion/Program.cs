using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo gf = new Grafo(8);

            gf.MostrarVertices();
            gf.LlenarMatriz();
            gf.MostrarMatriz();
            gf.CrearGrafo();
            gf.Recorrer(gf.lista_primero);
        }
    }
}
