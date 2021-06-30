using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldingTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (transform.name == "BigToolObj")
        {
            if (other.name == "BrackerTrigObj")
            {
                Debug.Log("Indicator2 is removed");
                CarCleaningmain.instance.brackerGrid.transform.GetChild(0).gameObject.SetActive(false);
            }

            if (other.name == "WeldingTrig1")   //Welding trig1 obj
            {
                CarCleaningmain.instance.brackerGrid.transform.GetChild(3).gameObject.SetActive(true);

            }


            if (other.name == "WeldingTrig2")   //Welding trig1 obj
            {
                CarCleaningmain.instance.brackerGrid.transform.GetChild(5).gameObject.SetActive(false); //Indicator1.2
                CarCleaningmain.instance.brackerGrid.transform.GetChild(6).gameObject.SetActive(true);  //Magic fire2

            }
        }



        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (transform.name == "BigToolObj")
        {
            if (other.name == "BrackerTrigObj")
            {
                
                //CarCleaningmain.instance.brackerGrid.transform.GetChild(0).gameObject.SetActive(true);
            }

            if(other.name == "WeldingTrig1")
            {
                CarCleaningmain.instance.brackerGrid.transform.GetChild(3).gameObject.SetActive(false);
                CarCleaningmain.instance.brackerGrid.transform.GetChild(0).gameObject.SetActive(false); //Indicator1 
                Invoke("Sparkle1", 0.5f);
            }

            if (other.name == "WeldingTrig2")
            {
                //CarCleaningmain.instance.brackerGrid.transform.GetChild(5).gameObject.SetActive(true);
                CarCleaningmain.instance.brackerGrid.transform.GetChild(6).gameObject.SetActive(false);  //Magic fire2
                CarCleaningmain.instance.brackerGrid.transform.GetChild(0).gameObject.SetActive(false); //Indicator1 
                Invoke("Sparkle2", 0.5f);
            }
        }
    }

    void Sparkle1()
    {
        CarCleaningmain.instance.brackerGrid.transform.GetChild(4).gameObject.SetActive(true);
        LeanTween.scale(CarCleaningmain.instance.brackerGrid.transform.GetChild(4).gameObject, new Vector3(2,2,2) ,2f)
            .setEasePunch()
                .setOnComplete(()=>
                {
                    CarCleaningmain.instance.brackerGrid.transform.GetChild(0).gameObject.SetActive(false); //Indicator1 
                    CarCleaningmain.instance.brackerGrid.transform.GetChild(5).gameObject.SetActive(true); //Indicator1.2
                });
    }

    void Sparkle2()
    {
        CarCleaningmain.instance.brackerGrid.transform.GetChild(7).gameObject.SetActive(true); //Spark2
        LeanTween.scale(CarCleaningmain.instance.brackerGrid.transform.GetChild(7).gameObject, new Vector3(2, 2, 2), 2f)
            .setEasePunch()
                .setOnComplete(() =>
                {
                    CarCleaningmain.instance.brackerGrid.transform.GetChild(0).gameObject.SetActive(false); //Indicator1 
                    CarCleaningmain.instance.DeactivateBrackerObj1();
                    //CarCleaningmain.instance.brackerGrid.transform.GetChild(5).gameObject.SetActive(true);
                });
    }
}
