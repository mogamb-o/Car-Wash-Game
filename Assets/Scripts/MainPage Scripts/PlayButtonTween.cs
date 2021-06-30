using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonTween : MonoBehaviour
{
    public float tweenTime;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<>();
        // float time = Random.Range(0.5f , 5);

        LeanTween.moveY(gameObject, -2.5f, 5f)
            .setDelay(1f)
                .setOnComplete(bump);
    }

    // Update is called once per frame   
    void bump()
    {
        LeanTween.scale(gameObject, new Vector3(3f, 3f, 3f), tweenTime)
            .setEasePunch()
                //.setDelay(0.5f)
                .setOnComplete(bump);
    }

    
}
