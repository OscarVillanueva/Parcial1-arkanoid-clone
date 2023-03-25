using UnityEngine;
using System;

public class SoftBlock : Block
{
    public SoftBlock(): base(Guid.NewGuid().ToString(), 1, false, 2, Color.gray) { 
    }

    public override void HandleDestroy()
    {
        base.HandleDestroy();
        Debug.Log("Bloque suave destruido");
        // TODO: Al acumular cierta cantidad de bloques activar que ciertos bloques desaparezcan o se muevan
    }
    
    // Quitar el handleDestroy y que sea fijo
    // Hacer un metodo virtual para que de acuerdo al short ver si ya se peude romper o no
}
