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

    //lista de productos en el puesto
    public List<productos_taller> inventario_puesto;

    //espacio en el inventario del puesto
    public int slots_inventario_puesto;

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

    public void añadir_item_puesto(productos_taller producto)
    {
        /*
         * añadir_item_puesto
         * funcion que añade un item al puesto de items para su venta.
         * teniendo en cuenta los slots que tiene el inventario
         * 
         * parametros:
         *  producto (productos_taller): producto a añadir
         */
        if (slots_inventario_puesto < inventario_puesto.Count)
        {
            inventario.Remove(producto);
            inventario_puesto.Add(producto);
        }
        else
        {
            Debug.Log("Slots llenos, espera a vender un producto");
        }
    }

    public void eliminar_item_puesto(productos_taller producto)
    {
        /*
         * eliminar_item_puesto
         * funcion que elimina la primera instancia de un item del inventario de puesto.
         * 
         * parametros:
         *  producto (productos_taller): producto a eliminar
         */

        inventario_puesto.Remove(producto);
    }




}
