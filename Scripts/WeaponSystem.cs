using System.Collections;

using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public WeaponType weaponType;
    public  enum WeaponType {Lasergun,Bow}

    public float damage;
    public float range;
    public float fireRate;


    public Camera fpsCamera;

    AudioSource source;
    public AudioClip[] weaponSounds;

    private float timeToFire;

    private void Start()
    {

        source = GetComponent<AudioSource>();

        if (weaponType == WeaponType.Lasergun)
        {
            source.clip = weaponSounds[0];
        }
        if(weaponType == WeaponType.Bow)
        {

            source.clip = weaponSounds[1];

        }
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= timeToFire)
        {

            timeToFire = Time.time + 1f / fireRate;
            Shoot();
            source.Play();

        }

    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {

            Debug.Log(hit.transform.name);

            EnemyBehavior enemyScript = hit.transform.GetComponent<EnemyBehavior>();

            if (enemyScript != null)
            {

                enemyScript.TakeDamage(damage);
            }
        }
    }
}
