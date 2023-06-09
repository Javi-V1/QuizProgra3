using Capa_Logica.Lista_Simple;

OrquestadorInt orquestadorInt = new OrquestadorInt();
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(1);

int cantidad = orquestadorInt.Busque_Valor(1);

Console.WriteLine(cantidad);