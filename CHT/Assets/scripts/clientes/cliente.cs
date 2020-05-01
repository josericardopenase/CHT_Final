using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "cliente/clientes", order = 1)]
public class cliente : ScriptableObject
{

    public float velocidad_de_movimiento;

    public int dinero_que_dan;

    public int clicks_para_vender;

    public Sprite imagen_del_personaje;

}
