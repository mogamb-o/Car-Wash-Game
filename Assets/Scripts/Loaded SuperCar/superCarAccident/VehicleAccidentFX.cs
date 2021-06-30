using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleAccidentFX : MonoBehaviour
{

    public AudioSource playMusic;
    public AudioClip storeMusic;

    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "Car2") //Vehicles accident sount effect
        {
            playMusic.PlayOneShot(storeMusic);

        }
        
        
    }

    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
