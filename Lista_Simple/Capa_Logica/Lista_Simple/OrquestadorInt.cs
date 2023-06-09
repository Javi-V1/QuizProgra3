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

        public bool Cabeza_No_Nula() {

            if (cabeza != null)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public int Busque_Valor(int _valor_A_Buscar) {

            int cantidad = 0;

            if (Cabeza_No_Nula()) {

                NodoInt nodoActual = cabeza;

                while (nodoActual!=null)
                {
                    if (nodoActual.Valor == _valor_A_Buscar)
                    { 
                        //cantidad = cantidad + 1;
                        cantidad++;
                       
                    }
                    nodoActual = nodoActual.Siguiente;
                }
            }
            return cantidad;  
        }
        public void Elimine_Nodo_Cabeza() {

            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                NodoInt aux = cabeza;
                nodoActual = nodoActual.Siguiente;
                aux = null;
                cabeza = nodoActual;
            }      
        
        
        }






    }
}
