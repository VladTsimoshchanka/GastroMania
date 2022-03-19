using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
  
    private int DonutAvailability = 3;
    private int CupcakeAvailability = 3;
    public Text DonutAvailabilityText;
    public Text CupcakeAvailabilityText;
    public GameObject[] foodPlaces;
    public Text ShopState;
    public GameObject foodPlace;
    public bool gameOver = false;
    public static float timeCount = 60.0f;
    public GameObject donut;
    public GameObject cupcake;
  
    // Get all of the food places where food objects will be placed
    void Start()
    {
        foodPlaces = GameObject.FindGameObjectsWithTag("FoodPlace");
    }
    
    //Add a donut to a not-occupied food place
    public void addDonut()
    {
        if(DonutAvailability > 0)
        {
            DonutAvailability -= 1;
            for (int i = 0; i < foodPlaces.Length; i++)
            {
                foodPlace = foodPlaces[i];
                if (foodPlace.GetComponent<FoodPlace>().isOccupied() == false)
                {
                    
                    foodPlace.GetComponent<FoodPlace>().addFood(donut);
                    break;
                }
            }
            DonutAvailabilityText.text = "Donuts available: " + DonutAvailability.ToString();
        }
        //If there is not more food left, display a message
         if(DonutAvailability == 0 && CupcakeAvailability == 0)
        {
            ShopState.text = "We are closed!";
        }
        
    }
    //Add a cupcake to a not-occupied food place
    public void addCupcake()
    {
        
        if (CupcakeAvailability > 0)
        {
            CupcakeAvailability -= 1;
            for (int i = 0; i < foodPlaces.Length; i++)
            {
                foodPlace = foodPlaces[i];
                if (foodPlace.GetComponent<FoodPlace>().isOccupied() == false)
                {

                    foodPlace.GetComponent<FoodPlace>().addFood(cupcake);
                    break;
                }
            }
            CupcakeAvailabilityText.text = "Cupcakes available: " + CupcakeAvailability.ToString();
        }
        //If there is not more food left, display a message
        if (DonutAvailability == 0 && CupcakeAvailability == 0)
        {
            ShopState.text = "We are closed!";
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        //Time calculation
        timeCount -= Time.deltaTime;
        if(timeCount <= 0)
        {
            gameOver = true;
        }
        
        
    }
    
    void OnGUI()
    {
        //If the game has ended due to time, display the end screen
        if (gameOver)
        {
            Time.timeScale = 0f;
            
            if (XRInputManager.IsButtonDown() || GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "The coffee shop kicked you out."))
            {
                Application.Quit();
            }

        }
    }
}
