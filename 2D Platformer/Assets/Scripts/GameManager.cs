using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool DebugMode = false;
    // Use this for initialization
    void Start()
    {
        Camera.main.transparencySortMode = TransparencySortMode.Orthographic;
    }

    // Update is called once per frame
    void Update()
    {
        if (DebugMode)
            if (Input.GetMouseButton(0))
                Debug.Break();
    }
}
