using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteManager : MonoBehaviour
{

    private bool isMuted;

    void Start()
    {
        isMuted = PlayerPrefs.GetInt("Muted") == 1;
        AudioListener.pause = isMuted;
    }

    public void MutePressed()
    {
        isMuted = !isMuted;

        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);


    }
    
    
}
