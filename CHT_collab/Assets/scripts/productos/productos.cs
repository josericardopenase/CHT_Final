using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class productos : ScriptableObject
{
    /*
     * productos:
     * clase padre de todos los productos que se crearan
     * 
     * parametros:
     *  nombre (string): nombre del producto
     *  descripcion (string): descripcion del producto
     *  precio (string): precio del producto
     */

    public string titulo;

    public string descripcion;

    public Sprite icono;

    public int precio;
}
