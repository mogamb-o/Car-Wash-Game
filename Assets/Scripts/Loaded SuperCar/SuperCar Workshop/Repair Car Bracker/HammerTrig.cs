using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTrig : MonoBehaviour
{
    public GameObject brackerObj3;
    public GameObject BigHammer;
    public GameObject ScrewObj2;
    public GameObject hammerTrigObj1;
    public GameObject hammerTrigObj2;

    void Start()
    {
        hammerTrigObj2.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (transform.name == "bigHammerObj")
        {
            if (other.name == "HammerTrig")
            {
                Debug.Log("Hammer Trig Activated");
                CarCleaningmain.instance.brackerGrid.transform.GetChild(8).gameObject.SetActive(false); //Hammer 2nd indicator
                GameManager.Instance.IndiDrag = false;
                CarCleaningmain.instance.brackerTools[2].GetComponent<BoxCollider2D>().enabled = false;
                //CarCleaningmain.instance.ActivateBrackerObj3();
                LeanTween.rotateZ(BigHammer, 60f, 0.5f)
                    .setOnComplete(()=> {
                        LeanTween.moveY(ScrewObj2, -1.5f, 1f)
                        .setOnComplete(() => {
                            LeanTween.rotateZ(BigHammer, 7f, 0.5f)
                                .setOnComplete(()=> {
                                    GameManager.Instance.IndiDrag = true;
                                    CarCleaningmain.instance.brackerTools[2].GetComponent<BoxCollider2D>().enabled = true;
                                    hammerTrigObj2.SetActive(true);
                                });
                                
                        }); 
                    });
            }

            if(other.name == "HammerTrig2")
            {
                hammerTrigObj1.SetActive(false);
                Debug.Log("Hammer Trig2 Activated");
                CarCleaningmain.instance.brackerGrid.transform.GetChild(8).gameObject.SetActive(false); //Hammer 2nd indicator
                GameManager.Instance.IndiDrag = false;
                CarCleaningmain.instance.brackerTools[2].GetComponent<BoxCollider2D>().enabled = false;
                //CarCleaningmain.instance.ActivateBrackerObj3();
                LeanTween.rotateZ(BigHammer, 60f, 0.5f)
                    .setOnComplete(() => {

                        LeanTween.moveY(ScrewObj2, -1.8f, 1f)
                        .setOnComplete(() => {

                            LeanTween.rotateZ(BigHammer, 7f, 0.5f)
                                .setOnComplete(() => {

                                    BigHammer.SetActive(false);
                                    //brackerObj3.SetActive(true);

                                });
                        });
                    });
            }
        }   
    }
}
