namespace Capa_Modelo.Nodo
{
    public abstract class Nodo<T,N,M>
    {
        public abstract T Valor{get;set;}

        public abstract N Siguiente { get; set; }

        public abstract M Key { get; set; }
    }
}
