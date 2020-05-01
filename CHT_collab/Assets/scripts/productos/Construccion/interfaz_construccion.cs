using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface interfaz_construccion
{

    /*
     * interfaz_construccion:
     * implementa un metodo construir modificable. aplicando el patron de diseño strategy.
     */

    void construir();
}


public class construir_con_clicks : interfaz_construccion
{
    /*
     * construir_con_clicks:
     * hereda de la interfaz de construccion. tiene un metodo construir el cual se hace con clicks.
     */

    void interfaz_construccion.construir()
    {
        Debug.Log("estoy construyendo con clicks");
    }
}

public class construir_con_dibujos : interfaz_construccion
{
    /*
     * construir_con_dibujos:
     * hereda de interfaz de construccion. implementa un metodo de construir a travez de dibujos.
     */

    void interfaz_construccion.construir()
    {
        Debug.Log("estoy construyendo con dibujos");
    }
}