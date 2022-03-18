using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
  
    private int availability1 = 3;
    private int availability2 = 3;
    public Text availability1Text;
    public Text availability2Text;
   
   
   
    public bool gameOver = false;
    public static float timeCount = 60.0f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    

    
    // Update is called once per frame
    void Update()
    {
        
        timeCount -= Time.deltaTime;
        if(timeCount <= 0)
        {
            gameOver = true;
        }
        
        
    }
    
    void OnGUI()
    {
        if (gameOver)
        {
            Time.timeScale = 0f;
            
            if (XRInputManager.IsButtonDown() || GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Game cleared. Totoal score: "))
            {
                Application.Quit();
            }

        }
    }
}
