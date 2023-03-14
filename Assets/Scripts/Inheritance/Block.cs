using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block
{
    public string Id { get; protected set; }

    public Color BlockColor { get;  protected set; }

    public int Hardness { get; protected set; }

    public bool IsPowerUp { get; protected set; }

    public int Points { get; protected set; }


    protected Block(string id, int hardness, bool isPowerUp, int points, Color baseColor)
    {
        Id = id;
        BlockColor = baseColor;
        Hardness = hardness;
        IsPowerUp = isPowerUp;
        Points = points;
    }

    public virtual void HandleDestroy() {
        // TODO: Solo avisar al manager cuantos puntos se le va a agregar
    }
}
