using Capa_Modelo.Nodo;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Capa_Logica.Lista_Simple
{
    public class OrquestadorInt
    {
        private NodoInt cabeza;

        public void Agregar_NodoInt(int valor) {

            NodoInt nodoNuevo = new NodoInt(valor);

            if (cabeza == null)
            {
                cabeza = nodoNuevo;
                nodoNuevo.Key = 0;
                cabeza.Key = nodoNuevo.Key;
            }
            else {

                NodoInt nodoActual = cabeza;
                nodoActual.Key = cabeza.Key;

                while (nodoActual.Siguiente != null) {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
                nodoNuevo.Key = nodoActual.Key + 1;
            }
        }

        public void Mostrar_Lista_Simple() {

            NodoInt nodoActual = cabeza;

            if (Cabeza_No_Nula())
            {
                Console.WriteLine("*-*-*-*Empieza Lista*-*-*-*");
                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }
                Console.WriteLine("*-*-*-*Termina Lista*-*-*-*");
            }
        }

        private bool Cabeza_No_Nula() {

            if (cabeza != null)
            {
                return true;
            }
            else {
                return false;
            }
        }
        
        private void Elimine_Nodo_Cabeza() {

            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                NodoInt aux = cabeza;
                nodoActual = nodoActual.Siguiente;
                aux = null;
                cabeza = nodoActual;
            } 
        
        }
        private int Lista_Lenght()
        {
            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                int length = 0;
                while (nodoActual != null)
                {
                    length++;
                    nodoActual = nodoActual.Siguiente;
                }
                return length;
            }
            else
            {
                return 0;
            }
        }
        private void Eliminar_Interativo(int _Key_Posicion, int _Cant_Nodos_Eliminados)
        {
            NodoInt nodoActual = cabeza;

            for(int i = 0; i>Lista_Lenght(); i++)
            {

            }
            NodoInt aux = nodoActual.Siguiente;
            nodoActual.Siguiente = aux.Siguiente;
            aux.Siguiente = null;
            aux = null;
        }
        public void Eliminar_Varios_Nodos(int _Key_Posicion, int _Cant_Nodos_Eliminados)
        {
            if(Cabeza_No_Nula()) 
            {
                NodoInt nodoActual= cabeza;
                if(_Key_Posicion == 0)
                {
                    Elimine_Nodo_Cabeza(); 
                }
                else
                {
                    while (nodoActual.Siguiente != null && nodoActual.Siguiente.Key != _Key_Posicion)
                    {
                        nodoActual = nodoActual.Siguiente;
                    }
                    
                    if(nodoActual.Siguiente.Siguiente == null)
                    {
                        nodoActual.Siguiente = null;
                    }
                    else
                    {
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("No existe ningun nodo en la lista");
            }
        }
    }
}
