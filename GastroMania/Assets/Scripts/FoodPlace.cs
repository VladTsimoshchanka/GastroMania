using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPlace : MonoBehaviour
{
    //Food place is supposed to place a food object in itself, so it cen either be occupied or no.
    public bool occupied = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool isOccupied()
    {
        return occupied;
    }
    //Adds food and becomes occupied
    public void addFood(GameObject food)
    {
        occupied = true;
        Instantiate(food, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
