using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewTrig : MonoBehaviour
{
    public GameObject screwObj;
    public GameObject screwObj2;
    public GameObject BigScrew;
    public GameObject screwDriver;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (transform.name == "bigScrewObj")
        {
            if (collision.name == "screwTrig")
            {
                Debug.Log("Screw Trig Activated");
                BigScrew.SetActive(false);
                //LeanTween.move(screwObj, new Vector3(0, 0, 0), 1f);
                GameManager.Instance.IndiDrag = false;
                CarCleaningmain.instance.brackerTools[1].GetComponent<BoxCollider2D>().enabled = false;

                //CarCleaningmain.instance.brackerTools[1].transform.GetChild(2).GetComponent<RectTransform>().anchoredPosition = new Vector2(-6f, 11f);

                screwObj.SetActive(true);
                CarCleaningmain.instance.brackerGrid.transform.GetChild(8).gameObject.SetActive(false);

                Invoke("moveScrew", 0.5f);
            }
        }
    }

    void moveScrew()
    {
        LeanTween.moveY(screwObj2, -0.1f, 1f);
        LeanTween.moveY(screwObj, -0.1f, 1f)
           .setOnComplete(() => {
               screwObj2.SetActive(true);
               screwObj.SetActive(false);


               LeanTween.moveY(screwObj, -0.3f, 1f);
               LeanTween.moveY(screwObj2, -0.3f, 1f)
                  .setOnComplete(() => {
                      screwObj.SetActive(true);
                      screwObj2.SetActive(false);


                      LeanTween.moveY(screwObj2, -0.5f, 1f);
                      LeanTween.moveY(screwObj, -0.5f, 1f)
                          .setOnComplete(() => {
                              screwObj2.SetActive(true);
                              screwObj.SetActive(false);

                              LeanTween.moveY(screwObj, -0.8f, 1f);
                              LeanTween.moveY(screwObj2, -0.8f, 1f)
                                  .setOnComplete(() =>
                                  {
                                      screwObj.SetActive(true);
                                      screwObj2.SetActive(false);

                                      LeanTween.moveY(screwObj2, -1.2f, 1f);
                                      LeanTween.moveY(screwObj, -1.2f, 1f)
                                          .setOnComplete(() =>
                                          {
                                              screwObj2.SetActive(true);
                                              screwObj.SetActive(false);

                                              screwDriver.SetActive(false);

                                              CarCleaningmain.instance.ActivateBrackerObj3();
                                          });
                                  });
                          });
                  });
           });

       


       
    }
}
