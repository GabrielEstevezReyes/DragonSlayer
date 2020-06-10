using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public Slider bull;
    public Slider bull1;
    private int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        bull.value = 1;
        bull1.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shoot()
    {
        bull.value -= 0.125f;
        a++;
        if (a % 3 == 0)
        {
            bull1.value -= 0.24f;
            this.GetComponent<AudioSource>().Play();
        }
        if(bull.value<=0 || bull1.value <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
