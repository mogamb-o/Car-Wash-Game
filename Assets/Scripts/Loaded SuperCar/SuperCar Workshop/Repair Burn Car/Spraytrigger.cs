using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spraytrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (transform.name == "SPTRIG")
        {
            if (other.name == "sprayoncar")
            {
               

                CarCleaningmain.instance.Carindi.SetActive(false);
                
                //Now increase the spray alpha value on the car
                CarCleaningmain.instance.SprayonCar.color = new Color(255f, 255f, 255f, CarCleaningmain.instance.SprayonCar.color.a + 0.01f); //Its fourth parameter is the alpha value
                if (CarCleaningmain.instance.SprayonCar.color.a >= 0.5)   //Applying check on Alpha value
                {
                    CarCleaningmain.instance.spraytrigfunc();

                    
                }
            }
        }
    }
}
