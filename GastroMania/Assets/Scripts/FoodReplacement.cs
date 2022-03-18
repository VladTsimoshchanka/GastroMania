﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodReplacement : MonoBehaviour
{
    [Range(0, 360)]
    public float maximumAngleForEvent = 30f;
    public GameObject foodSelf;
    public GameObject alterEgo;
    public bool isOriginal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var cameraForward = Camera.main.transform.forward;
        var vectorToObject = transform.position - Camera.main.transform.position;

        // Check if the angle between the camera and object is within the hover range
        var angleFromCameraToObject = Vector3.Angle(cameraForward, vectorToObject);
        if (isOriginal)
        {
            
            if (angleFromCameraToObject <= maximumAngleForEvent)
            {
                AlterFood();
            }
        }
        else
        {
            if (angleFromCameraToObject > maximumAngleForEvent)
            {
                AlterFood();
            }
        }
        
    }
    public void AlterFood()
    {
        Destroy(gameObject);
        Instantiate(alterEgo, transform.position, transform.rotation);
    }
}
