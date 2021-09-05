using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();

            Console.WriteLine("El arbol esta vacio? : " + arbol.EstaVacio());
            arbol.AgregarNodo(8);
            arbol.AgregarNodo(6);
            arbol.AgregarNodo(9);
            arbol.AgregarNodo(3);
            arbol.AgregarNodo(7);
            arbol.AgregarNodo(14);
            Console.WriteLine("El arbol esta vacio? : " + arbol.EstaVacio());
            Console.WriteLine("Cantidad de nodos en el arbol: "+arbol.ObtenerCantidadNodos());
            Console.WriteLine("Cantidad de hojas en el arbol: " + arbol.ObtenerCantidadHojas());

            Console.ReadLine();
        }
    }
}
