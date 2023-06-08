using Capa_Acceso_Datos.Txt;
using Capa_Modelo.Nodo;

namespace Capa_Logica.Lista_Simple
{
    public class OrquestadorString
    {
        private NodoString cabeza;
        

        public void Agregar_NodoString(string valor)
        {
            NodoString nodoNuevo = new NodoString(valor);

            if (cabeza == null)
            {
                cabeza = nodoNuevo;
            }
            else
            {
                NodoString nodoActual = cabeza;

                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
            }
        }

        public void Mostrar_Lista_Simple()
        {

            NodoString nodoActual = cabeza;

            if (nodoActual != null)
            {
                Console.WriteLine("*-*-*-*Empieza Lista*-*-*-*");
                while (nodoActual != null)
                {
                    string valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }
                Console.WriteLine("*-*-*-*Termina Lista*-*-*-*");
            }

        }

        public void Escribir_Lista_En_Txt() {

            Escritura_Txt escritura = new Escritura_Txt();
            escritura.Escriba_En_TxT("Hola","","Prueba.txt");
        
        }

    }
}
