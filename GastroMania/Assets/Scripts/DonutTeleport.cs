using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DonutTeleport : MonoBehaviour
{
    [Range(0, 360)]
    public float maximumAngleForEvent = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Donut teleports a player to the second scene if the camera angle is right and the player pressed a button.
    void Update()
    {
        var cameraForward = Camera.main.transform.forward;
        var vectorToObject = transform.position - Camera.main.transform.position;

        // Check if the angle between the camera and object is within the hover range
        var angleFromCameraToObject = Vector3.Angle(cameraForward, vectorToObject);
        if (angleFromCameraToObject <= maximumAngleForEvent)
        {
            if (XRInputManager.IsButtonDown())
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
