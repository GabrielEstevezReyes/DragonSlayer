using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonShooter : MonoBehaviour
{
    private float time = 0;
    public bool starting = false;
    public GameObject bulletPrefab;
    public Transform bulletPlace;
    public Transform targ;

    // Update is called once per frame
    void Update()
    {
        if (starting)
        {
            time += Time.deltaTime / 100;
            if(time >= 3)
            {
                GameObject a = Instantiate(bulletPrefab, bulletPlace.position, bulletPrefab.transform.rotation);
                a.transform.forward = targ.transform.position - transform.position;
                a.GetComponent<Bullet>().init = true;
                time = 0;
            }
        }        
    }
}
