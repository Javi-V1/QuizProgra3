using Capa_Logica.Lista_Simple;

OrquestadorInt orquestadorInt = new OrquestadorInt();
 

orquestadorInt.Agregar_NodoInt(1);
orquestadorInt.Agregar_NodoInt(2);
orquestadorInt.Agregar_NodoInt(3);
orquestadorInt.Agregar_NodoInt(4);
orquestadorInt.Agregar_NodoInt(5);

orquestadorInt.Mostrar_Lista_Simple();

//Se coloca como primer parametro el NODO desde donde se quiere posicionar empezando a contar desde el 1,
//Y el segundo la cantidad de nodos a eliminar apartir de ahi
orquestadorInt.Eliminar_Varios_Nodos(0, 1);

orquestadorInt.Mostrar_Lista_Simple();