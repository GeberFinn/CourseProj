using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    float Maxintensity = 5.5f;
    float Minintensity = 5.0f;
    public Light lght;
    bool full = false;
	// Use this for initialization

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Quit()
    {     
        
        Application.Quit();
    }
    public void Light()
    {
        lght.enabled = false;
        
    }

   
}
