using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool init = false;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (init)
        {
            time += Time.deltaTime;
            transform.Translate(Vector3.forward * Time.deltaTime);
            if (time >= 5)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
