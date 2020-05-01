using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "objeto/cubo", order = 1)]
public class objeto_cubo : objeto
{
    public Sprite textura;

    public int dureza;

    public GameObject drop;

    public void drop_item()
    {
        //instanciar el objeto drop en la posicion del objeto actual
    }
}
