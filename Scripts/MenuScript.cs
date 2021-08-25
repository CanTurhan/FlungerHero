using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public void PlayButton() // function that you can load scene(1) first level.
    {
        SceneManager.LoadScene(1);





    }



    public void SettingsButton()

    {


        SceneManager.LoadScene(4);

    }
   
    public void ExitButton() // funciton that you can exit game.
    {


        Application.Quit();



    }
}
