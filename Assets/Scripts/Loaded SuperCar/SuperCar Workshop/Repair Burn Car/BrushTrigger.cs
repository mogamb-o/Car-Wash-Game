using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BrushTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (transform.name == "bigBurnObj")
        {
            if (other.name == "sprayoncar")
            {
                CarCleaningmain.instance.Carindi.SetActive(false);

                //Now increase the spray alpha value on the car
                CarCleaningmain.instance.SprayonCar.color = new Color(255,255,255, CarCleaningmain.instance.SprayonCar.color.a + 0.01f);
                if (CarCleaningmain.instance.SprayonCar.color.a >= 1)
                {
                    CarCleaningmain.instance.DeactivateToolTwo();
                }

            }
        }
    }

}
