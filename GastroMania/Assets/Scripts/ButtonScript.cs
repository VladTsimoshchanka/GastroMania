using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Material normal;
    public Material changedColor;
    public bool changed = false;
    [Range(0, 360)]
    public float maximumAngleForEvent = 5f;
    public GameControl gameControl;
    public bool addDonut;
    // Find the game control file to interact with it
    void Start()
    {
        gameControl = GameObject.Find("PlayerCamera").GetComponent<GameControl>();
    }

    //Do the food placement depedning on what food this button is responsible for
    public void ButtonPressed()
    {
        if (addDonut)
        {
            gameControl.addDonut();
        }
        else
        {
            gameControl.addCupcake();
        }

    }
}
