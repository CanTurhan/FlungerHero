using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{

    public float sayi;
    public Text sayiyazi, ipucuyazi;
    public GameObject bar, ekran;
    
    
    void Start()
    {
        ekran.SetActive(true);
    }


    void Update()
    {
        if (sayi < 100 ) 
         {
            sayi += Time.deltaTime * 15;

        }

        if (sayi >= 100)
        {
            sayi = 100;

            ekran.SetActive(false);
            SceneManager.LoadScene(0);
        }
        sayiyazi.text = " "+(int)sayi + "%";
        bar.transform.localScale = new Vector3(sayi/100, 1, 1);
    }

}