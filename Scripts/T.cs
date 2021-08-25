using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
            if(Input.touchCount > 0)
        {

            Touch finger = Input.GetTouch(0);


                if(finger.phase== TouchPhase.Began)
            {

                Debug.Log("Touched");
                Debug.Log(finger.position);

            }
            if (finger.phase == TouchPhase.Stationary)
            {

                Debug.Log("Touching..");

            }
            if (finger.phase == TouchPhase.Moved)
            {

                Debug.Log("progress");

            }
            if (finger.phase == TouchPhase.Ended)
            {

                Debug.Log("Touch  ended");

            }

        }
    }
}
