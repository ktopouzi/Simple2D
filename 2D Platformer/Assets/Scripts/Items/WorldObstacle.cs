using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldObstacle : Interactable
{
   public Type type;

    public override void Interact()
    {
        base.Interact();
    }

    public enum Type
    {
        Enemy,
        Powerup
    }
}
