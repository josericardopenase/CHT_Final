using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "productos/productos_taller", order = 1)]
public class productos_taller : productos
{
    /*
     * productos_venta:
     * clase derivada de productos. Especifica para los productos de tipo de venta.
     * 
     * parametros:
     *  click_para_vender (int): clicks necesarios para vender un producto.
     *  materiales_para_construccion (lista de productos_materiales): lista que especificara con que se craftea cada producto.
     */

      public int clicks_para_vender;

      public List<productos_materiales> materiales_para_construccion;

      public virtual void Construccion()
       {
            
       }


}



