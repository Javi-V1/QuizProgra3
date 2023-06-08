using Capa_Modelo.Nodo;

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
            }
            else {

                NodoInt nodoActual = cabeza;

                while (nodoActual.Siguiente != null) {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
            }
        }

        public void Mostrar_Lista_Simple() {

            NodoInt nodoActual = cabeza;

            if (nodoActual != null)
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
    }
}
