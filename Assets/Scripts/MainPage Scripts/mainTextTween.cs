using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainTextTween : MonoBehaviour
{
    public float tweenTime;
    // Start is called before the first frame update
    void Start()
    {
        //LeanTween.cancel(gameObject);

        LeanTween.scale(gameObject, new Vector3(8f, 5f, 0f), tweenTime)
            .setEasePunch()
                //.setDelay(0.5f)
                .setOnComplete(Start);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
