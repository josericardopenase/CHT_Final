using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crear_bloque : MonoBehaviour
{

    public objeto_cubo cubo;

    public int dureza;
    public GameObject drop;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = cubo.textura;
        dureza = cubo.dureza;
        drop = cubo.drop;
    }


}
