using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveTruck : MonoBehaviour
{
    public GameObject vehicleDent; //Setup supercar and truck dent
    public GameObject boom;   //Set it as Boom Sign 
    public GameObject fireExtingusher;
    public GameObject fire;

    public GameObject car;
    public GameObject truck;

    public GameObject dirtyCar;
    public GameObject dirtyTruck;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveX(gameObject, 5.1f, 1f)
                .setOnComplete(() =>
                {
                    boom.SetActive(true);
                    vehicleDent.SetActive(true);
                });

            activateButton();
                
    }

    public IEnumerator SetButton()
    {             
        yield return new WaitForSeconds(2f);
        boom.SetActive(false);

        fire.SetActive(true); //Activating the disable fire

        car.SetActive(false);
        dirtyCar.SetActive(true);

        truck.SetActive(false);
        dirtyTruck.SetActive(true);


        fireExtingusher.SetActive(true);
        
        LeanTween.scale(fireExtingusher, new Vector3(1.5f, 1.5f, 1.5f), 5f)
          .setEasePunch();
        
    }


    public void activateButton()
    {
        StartCoroutine(SetButton());
    }

    // Update is called once per frame

   
    void Update()
    {
      
    }
}
