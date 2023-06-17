using Capa_Logica.Lista_Simple;

OrquestadorInt orquestadorInt = new OrquestadorInt();

orquestadorInt.Agregar_NodoInt(0);
orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(2);
orquestadorInt.Agregar_NodoInt(3);
orquestadorInt.Agregar_NodoInt(4);

orquestadorInt.Mostrar_Lista_Simple();

orquestadorInt.Eliminar_Varios_Nodos(3, 2);

orquestadorInt.Mostrar_Lista_Simple();