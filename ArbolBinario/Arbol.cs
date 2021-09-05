namespace ArbolBinario
{
    //Metodo EstaVacio -- si el nodo raiz es null, entonces el arbol esta vacio
    //Metodo AgregarNodo -- agrega nodo en la raiz o ramas segun sea necesario
    //metodo ObtenerCantidadNodos -- retorna conteo de nodos en el arbol
    //metodo ObtenerCantidadHojas -- retorna conteo de la cantidad de hojas
    //metodo VerificarSiEsHoja(int value) -- verifica si el nodo existe, si existe, retorna verdadero si los hijos del nodo son null

    public class Arbol
    {
        private Nodo Raiz;
        private int CantidadNodos;
        private int CantidadHojas;

        public bool EstaVacio()
        {
            return Raiz == null;
        }

        public void AgregarNodo(int valor)
        {
            AgregarNodo(ref Raiz, valor);
        }

        private void AgregarNodo(ref Nodo nodoActual, int valor)
        {
            if (nodoActual == null) //si la raiz es igual a null, significa que esta vacio y se inserta el valor(dato) como raiz del nodo
            {
                nodoActual = new Nodo { Dato = valor, HijoIzq = null, HijoDer = null };
            }
            else
            {
                //si el arbol no esta vacio, debemos verificar el valor de la raiz para insertar a la izquierda o derecha
                //si el valor a insertar es menor que el valor raiz, se inserta por la izquierda.
                //si el valor a insertar es mayor que el valor raiz, se inserta por la derecha.
                int valorNodo = nodoActual.Dato;
                if (valor < valorNodo)
                {
                    AgregarNodo(ref nodoActual.HijoIzq, valor);
                }
                else
                {
                    AgregarNodo(ref nodoActual.HijoDer, valor);
                }
            }
        }

        public int ObtenerCantidadNodos()
        {
            CantidadNodos = 0;

            ContarNodos(ref Raiz);

            return CantidadNodos;
        }

        private void ContarNodos(ref Nodo nodoActual)
        {
            if (nodoActual != null)
            {
                CantidadNodos++;
                ContarNodos(ref nodoActual.HijoIzq);
                ContarNodos(ref nodoActual.HijoDer);
            }
        }

        public int ObtenerCantidadHojas()
        {
            CantidadHojas = 0;
            ContarHojas(Raiz);
            return CantidadHojas;
        }

        private void ContarHojas(Nodo nodoActual)
        {
            if (nodoActual != null && (nodoActual.HijoIzq == null && nodoActual.HijoDer == null))
            {
                CantidadHojas++;
            }

            if (nodoActual != null)
            {
                ContarHojas(nodoActual.HijoIzq);
                ContarHojas(nodoActual.HijoDer);
            }
        }

    }

    public class Nodo
    {
        public int Dato;
        public Nodo HijoDer;
        public Nodo HijoIzq;
    }
}