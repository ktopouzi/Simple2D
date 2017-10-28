using UnityEngine;
using System.Collections.Generic;
public class Interactable : MonoBehaviour {

    public float radius = 1f;
    public Transform player;

    public virtual void Interact()
    {
        print("interacting with "+ transform.name);
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        float distance = Vector2.Distance(player.position, transform.position);
        if (distance <= radius)
            print("Interact");
    } 
    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Interact();
    //        print("You hit the player, now if that's a power up do something, if you are an enemy show some mercy!");
    //    }
    //}
}
