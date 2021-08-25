using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Next : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    void OnTriggerEnter(Collider obje1)
    {


        if (obje1.tag == "door")
        {

            SceneManager.LoadScene(3);


        }

    }
}
