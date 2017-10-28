using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<WorldObstacle> ObjectPool;
    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        foreach (var item in ObjectPool)
        {
            float rand = UnityEngine.Random.Range(0f, 100f);
            print(rand);
            if (item.type == WorldObstacle.Type.Powerup && rand > 50)
            {
                GameObject.Destroy(this);
               var spanwed =  Instantiate(item, this.GetComponentInParent<Transform>().position,Quaternion.identity);
                spanwed.transform.parent = transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
