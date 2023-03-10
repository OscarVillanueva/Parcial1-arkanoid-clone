using UnityEngine;
using System;

public class HardBlock : Block
{
    public HardBlock() : base(Guid.NewGuid().ToString(), 2, false, 10,Color.green)
    {
    }

    public override void HandleDestroy()
    {
        Debug.Log("Bloque duro destruido");
        // TODO: cuando rompas un bloque duro la aumenta 0.01% la probabilidad de sacar un powerup
    }
}