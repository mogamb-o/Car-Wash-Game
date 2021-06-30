using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RollerTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if(transform.name == "bigBurnObj")
        {
            if (other.name == "sprayoncar") 
            {
                CarCleaningmain.instance.Carindi.SetActive(false);

                CarCleaningmain.instance.SprayonCar.color = new Color(255,255,255, CarCleaningmain.instance.SprayonCar.color.a - 0.01f);
                CarCleaningmain.instance.burnStain.SetActive(false);
                if(CarCleaningmain.instance.SprayonCar.color.a <= 0f)
                {
                    CarCleaningmain.instance.DeactivateToolThree();
                }


            }
        }
    }
}
