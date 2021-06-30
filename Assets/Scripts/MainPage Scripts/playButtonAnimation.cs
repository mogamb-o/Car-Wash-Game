using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButtonAnimation : MonoBehaviour
{
    public float tweenTime;
    // Start is called before the first frame update
    void Start()
    {
        //LeanTween.cancel(gameObject);

        LeanTween.scale(gameObject, new Vector3(3f, 3f, 3f), tweenTime)
            .setEasePunch()
                //.setDelay(0.5f)
                .setOnComplete(Start);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
