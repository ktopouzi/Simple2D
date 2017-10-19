using UnityEngine;
using System.Collections.Generic;
public class Interactable : MonoBehaviour {

    public float radius = 1f;

    public virtual void Interact()
    {
        print("interacting with "+ transform.name);
    }
    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(transform.position, radius);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Interact();
            print("You hit the player, now if that's a power up do something, if you are an enemy show some mercy!");
        }
    }
}
