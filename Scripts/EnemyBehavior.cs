using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{



    public float health;

    public void TakeDamage(float amount)
    {


        health -= amount;

        if(health <= 0f)
        {

            Death();
        }



    }

    private void Death()
    {

        Destroy(gameObject);


    }
}
