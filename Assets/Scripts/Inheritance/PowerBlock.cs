using System;
using UnityEngine;

public class PowerBlock : Block
{
    public PowerBlock() : base(Guid.NewGuid().ToString(), 1, true, 5, Color.yellow)
    {
    }

    // TODO: Definir una funcion para pedir un gameobject la funcion de game object
    // Esta funcion debe ser llamada antes del handleDestroy

    public override void HandleDestroy()
    {
        Debug.Log("Bloque power destruido");
    }
}
