using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory_manager: MonoBehaviour
{
    /*
     * inventory_manager
     * singleton desde el cual nos permitira gestionar el inventario de manera publica.
     * este tendra una lista de elementos tipo productos.
     * 
     * atributos:
     *  inventario (lista de productos): lista que guardara el inventario del jugador.
     *  instancia (inventory_manager): instancia publica del inventario.
     */

    //instancia publica del inventario
    public static inventory_manager instancia;

    //lista de productos (el inventario en si)
    public List<productos> inventario;

    //Desarrollar singleton para el Inventario (basandose en el game_manager) tarea: NICO.
    #region singleton
        
    #endregion

    public void añadir_item(productos producto)
    {
        /*
         * añadir_item:
         * funcion que añade un producto al inventario
         * 
         * parametros:
         *  producto (productos): producto que se quiere añadir al inventario
         */

        inventario.Add(producto);
    }

    public void eliminar_item(productos producto)
    {
        /*
         * eliminar_item:
         * funcion que elimina la primera instancia de un item en el inventario
         * 
         * parametros:
         *  producto (productos): producto que se quiere eliminar del inventario
         */

        inventario.Remove(producto);
    }






}
