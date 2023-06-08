namespace Capa_Modelo.Nodo
{
    public class NodoString : Nodo<string, NodoString>
    {
        public override string Valor { get; set; }
        public override NodoString Siguiente { get ; set; }

        public NodoString(string _valor)
        {
            Valor = _valor;
            Siguiente = null;
            
        }
    }
}
