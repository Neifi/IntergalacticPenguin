using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : UnityEngine.MonoBehaviour {

	public void PlayButton ()
    {
        SceneManager.LoadScene("SampleScene",0);
    }
    public void QuitButton()
    {
        Application.Quit();
        
    }
   
}
