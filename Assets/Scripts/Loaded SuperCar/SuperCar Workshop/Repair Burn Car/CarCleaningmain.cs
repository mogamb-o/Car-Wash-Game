using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarCleaningmain : MonoBehaviour
{
    //repair burning part
    public static CarCleaningmain instance;
    public GameObject LoadRepairBurn;
    public GameObject[] Tools;
    public GameObject Carindi;
    public Image SprayonCar;
    public GameObject repairBraker; //Bracker repair message
    public GameObject burnStain;
    public GameObject grid;

    //--------------------------------------------------------------------

    // Bracker repair part
    public GameObject loadBrakerRepair;
    public GameObject[] brackerTools;
    //public GameObject secondIndicator;
    public GameObject brackerGrid;
    public GameObject brackerTrigObj;

    //Master of Science in Games Development and Design

    void Start()
    {
        instance = this;
        Tools[1].GetComponent<BoxCollider2D>().enabled = false;
        Tools[1].transform.GetChild(1).gameObject.SetActive(false);

        Tools[2].GetComponent<BoxCollider2D>().enabled = false;
        Tools[2].transform.GetChild(1).gameObject.SetActive(false);

        //--------------------------------------------------------------
        //Bracker Tools

        brackerTools[1].GetComponent<BoxCollider2D>().enabled = false;
        brackerTools[1].transform.GetChild(1).gameObject.SetActive(false);

        brackerTools[2].GetComponent<BoxCollider2D>().enabled = false;
        brackerTools[2].transform.GetChild(1).gameObject.SetActive(false);
    }
    public void spraytrigfunc() //Run when alpha value reaches to 1
    {
        GameManager.Instance.IndiDrag = false;
        Tools[0].GetComponent<BoxCollider2D>().enabled = false;
        Tools[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(-18.35986f, 321.7714f); //Move back the obj to its default position 


        Tools[0].transform.GetChild(0).gameObject.SetActive(true);  //Trun on the orignal tool
        Tools[0].transform.GetChild(1).gameObject.SetActive(false); //Trun off the Spray Tool
        Tools[0].transform.GetChild(2).gameObject.SetActive(false); //Turn off the indicator

        
        Invoke("activetooltwo",0.5f);
    }
    void activetooltwo()
    {
        Tools[1].transform.GetChild(1).gameObject.SetActive(true);
        Tools[1].GetComponent<BoxCollider2D>().enabled = true;
        
        GameManager.Instance.IndiDrag = true;

    }

    public void DeactivateToolTwo()
    {
        Tools[1].transform.GetChild(1).gameObject.SetActive(false);
        GameManager.Instance.IndiDrag = false;
        Tools[1].GetComponent<BoxCollider2D>().enabled = false;
        Tools[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 20f);

        Tools[1].transform.GetChild(0).gameObject.SetActive(true);
        
        Tools[1].transform.GetChild(2).gameObject.SetActive(false);

        Invoke("ActivateToolThree", 0.5f);
    }

    void ActivateToolThree()
    {
   
        Tools[2].transform.GetChild(1).gameObject.SetActive(true);
        Tools[2].GetComponent<BoxCollider2D>().enabled = true;

        GameManager.Instance.IndiDrag = true;
    }

    public void DeactivateToolThree()
    {

        Tools[2].transform.GetChild(1).gameObject.SetActive(false);
        GameManager.Instance.IndiDrag = false;
        Tools[2].GetComponent<BoxCollider2D>().enabled = false;
        Tools[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(-21f, -254f);

        Tools[2].transform.GetChild(0).gameObject.SetActive(true);
       
        Tools[2].transform.GetChild(2).gameObject.SetActive(false);

        Invoke("DisplayMessage", 2f);
    }

    void DisplayMessage()
    {
        repairBraker.SetActive(true);
        LeanTween.moveY(repairBraker, 0f, 2f)
            .setEaseOutBounce()
                .setOnComplete(() =>
                 {
                     
                     LeanTween.moveY(repairBraker, 10f, 6f);
                     grid.SetActive(false);
                 })
                 .setOnComplete(()=>
                 {

                     Invoke("loadBrakersRepair", 2f);

                 });

       
    }

    void loadBrakersRepair()
    {
        loadBrakerRepair.SetActive(true);
        LoadRepairBurn.SetActive(false);
    }

    public void DeactivateBrackerObj1()
    {
        CarCleaningmain.instance.brackerGrid.transform.GetChild(0).gameObject.SetActive(false); //Indicator2
        brackerTools[0].transform.GetChild(1).gameObject.SetActive(false); //Indicator1
        brackerTools[0].GetComponent<BoxCollider2D>().enabled = false;
        GameManager.Instance.IndiDrag = false;
        brackerTools[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(-18.35986f, 321.7714f);
        

        brackerTools[0].transform.GetChild(0).gameObject.SetActive(true);  //Orignal tool
        brackerTools[0].transform.GetChild(1).gameObject.SetActive(false); //Indicator
        brackerTools[0].transform.GetChild(2).gameObject.SetActive(false); //BigTool

        Invoke("ActivateBrackerObj2", 0.5f);
    }

    public void ActivateBrackerObj2()
    {
        brackerTools[0].GetComponent<BoxCollider2D>().enabled = false;
        brackerTools[0].transform.GetChild(1).gameObject.SetActive(false); //Indicator1 of wellder

        brackerTools[2].GetComponent<BoxCollider2D>().enabled = false;
        brackerTools[2].transform.GetChild(1).gameObject.SetActive(false); //Indicator 1 of hammer

        brackerTools[1].transform.GetChild(1).gameObject.SetActive(true);
        brackerTools[1].GetComponent<BoxCollider2D>().enabled = true; 
        GameManager.Instance.IndiDrag = true;
    }

    public void ActivateBrackerObj3()
    {
        brackerTools[0].GetComponent<BoxCollider2D>().enabled = false;
        brackerTools[0].transform.GetChild(1).gameObject.SetActive(false); //Indicator1 of wellder

        brackerTools[1].GetComponent<BoxCollider2D>().enabled = false;
        brackerTools[1].transform.GetChild(1).gameObject.SetActive(false); //Indicator 1 of screw

        brackerTools[2].transform.GetChild(1).gameObject.SetActive(true);
        brackerTools[2].GetComponent<BoxCollider2D>().enabled = true;
        GameManager.Instance.IndiDrag = true;


    }
}
