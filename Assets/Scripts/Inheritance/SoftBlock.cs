using UnityEngine;
using System;

public class SoftBlock : Block
{
    public SoftBlock(): base(Guid.NewGuid().ToString(), 1, false, 2,Color.blue) { 
    }

    public override void HandleDestroy()
    {
        Debug.Log("Bloque suave destruido");
        // TODO: cuando un bloque suave la bola aumenta de velocidad en 0.1%
    }
}
