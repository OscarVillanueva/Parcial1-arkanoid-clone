﻿using UnityEngine;
using System;

public class HardBlock : Block
{
    public HardBlock() : base(Guid.NewGuid().ToString(), 2, false, 10,Color.green)
    {
    }

    public override void HandleDestroy()
    {
        Debug.Log("Bloque duro destruido");
        // TODO: Avisar la manager que un bloque se rompio y avisar el cuantos puntos da
        // TODO: cuando un bloque duro la bola aumenta de velocidad en 1%
    }
}