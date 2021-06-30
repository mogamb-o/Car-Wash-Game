using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopFireTrigger : MonoBehaviour
{
    public GameObject fire;
    public ParticleSystem fireParticleSystem;
    public GameObject removeFireExtingusher;
    [SerializeField] private GameObject indicator2;
    [SerializeField] private GameObject btnFireExtingusher;
    public GameObject message; //Object for message board
    public GameObject spray; //Object for spray


    public AudioSource playMusic;
    public AudioClip storeMusic;
    public float volume1;

    public AudioSource playAchievementMusic;
    public AudioClip storeAchievementMusic;
    public float volume2;
    bool alreadyPlayed2 = false;

    public GameObject sprayObject;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "FireObject")
        {

            //Debug.Log("Fire extinguish");
            //for (float i = 4.5f; i >= 0.0f; i--)
            //{
            //spray.SetActive(true);  //Activates the spray of fire extinguisher

                playMusic.PlayOneShot(storeMusic, volume1);


            ActivateMinimizeFire();



            //removeFireExtingusher.SetActive(false);
            //}

            activateRemove();


        }




    }
    private void OnTriggerExit2D(Collider2D collision)
    {
                playMusic.Stop();

    }
    public IEnumerator remove()
    {

        yield return new WaitForSeconds(3f);
    //    fire.SetActive(false);  //Turn off the fire
    //     spray.SetActive(false); //Turn off the spray of the fire extinguisher


        if (!alreadyPlayed2) //Play the music only once
        {
            playAchievementMusic.PlayOneShot(storeAchievementMusic, volume2);
            alreadyPlayed2 = true;
        }

        yield return new WaitForSeconds(1f);

        removeFireExtingusher.SetActive(false);

        btnFireExtingusher.SetActive(false);
        //playAchievementMusic.PlayOneShot(storeAchievementMusic);




        message.SetActive(true);
        LeanTween.moveY(message, 0f, 2f)
            .setEaseOutBounce()
                .setDelay(1f)
              .setOnComplete(()=>{
                //removeFireExtingusher.SetActive(true);
                //sprayObject.SetActive(true);
                SceneManager.LoadScene(6);
                
                //SceneManager.LoadScene(6);
                //ActivateSuperCarWorkshopScene();
                });
        //yield return new WaitForSeconds(1f);
        //Debug.Log("Message sholud display");
        //message.SetActive(true);
    }


    public void activateRemove()
    {
        StartCoroutine(remove());
    }


    //--------------------------------------------------------------------------------


    public IEnumerator MinimizeFire()
    {

        yield return new WaitForSeconds(3f);



        var emitte = fireParticleSystem.emission;
        emitte.rateOverTime = 0;

        fire.SetActive(false);
        indicator2.SetActive(false);

    }


    public void ActivateMinimizeFire()
    {
        StartCoroutine(MinimizeFire());
    }

    // public IEnumerator superCarWorkshopScene()
    // {
    //   //removeFireExtingusher.SetActive(false);
    //   yield return new WaitForSeconds(3f);
    //   SceneManager.LoadScene(6);

    // }

    // public void ActivateSuperCarWorkshopScene(){
    //   StartCoroutine(superCarWorkshopScene());
    // }

}
