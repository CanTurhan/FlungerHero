using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bolum : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter( Collider obje) 
    {


        if ( obje.tag=="kapi")
        {

            SceneManager.LoadScene(2);

                
        }

    }
}
