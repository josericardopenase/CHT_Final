using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "productos/productos_materiales", order = 2)]
public class productos_materiales : productos
{
    /*
     * productos_materiales:
     * clase derivada de productos, estos seran aquellos productos los cuales se usaran para
     * construir los productos de taller.
     *(incluyen las herramientas)
     * 
     * parametros:
     *  usos (int): cantidad de usos que tiene un material
     */

    public categoria_material categoria;

    public int usos;

    
}
public enum categoria_material{

    materias_primas,
    herramientas

}