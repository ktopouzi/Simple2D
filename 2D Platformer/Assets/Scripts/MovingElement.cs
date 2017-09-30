using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingElement : MonoBehaviour
{
    public float backgroundSize;
    public float paralaxSpeed;
    public bool randomHeight;

    private Transform cameraTransform;
    public Transform[] layers;
    private float viewZone = 10;
    private int leftIndex;
    private int rightIndex;
    private float lastCameraX;

    // Use this for initialization
    void Start()
    {
        layers = new Transform[transform.childCount];
        cameraTransform = Camera.main.transform;
        lastCameraX = cameraTransform.position.x;

        for (int i = 0; i < transform.childCount; i++)
        {
            layers[i] = transform.GetChild(i);
        }

        leftIndex = 0;
        rightIndex = layers.Length - 1;

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            if (cameraTransform.position.x < (layers[leftIndex].transform.position.x + viewZone))
                ScrollLeft();

            if (cameraTransform.position.x > (layers[rightIndex].transform.position.x - viewZone))
                ScrollRight();
        }
        catch (Exception e)
        {

            print(e.Data);
        }

    }

    private void ScrollLeft()
    {
        float currentY = transform.GetChild(0).position.y;
        float s = UnityEngine.Random.Range(0, 3);
        print(currentY);
        int lastRight = rightIndex;
        if (randomHeight)
        {
            layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x - backgroundSize) + new Vector3(0, UnityEngine.Random.Range(currentY, 2), 0);
        }else
        {
            layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x - backgroundSize) + new Vector3(0, currentY, 0);
        }  
        leftIndex = rightIndex;
        rightIndex--;
        if (rightIndex < 0)
            rightIndex = layers.Length - 1;

    }

    private void ScrollRight()
    {
        float currentY = transform.GetChild(0).position.y;
        print(currentY);
        int lastLeft = leftIndex;
        if (randomHeight)
        {
            layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize) + new Vector3(0, UnityEngine.Random.Range(currentY, 2), 0);
        }
        else
        {
            layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize) + new Vector3(0, currentY, 0);
        }
       
        rightIndex = leftIndex;
        leftIndex++;
        if (leftIndex == layers.Length)
            leftIndex = 0;
    }
}
