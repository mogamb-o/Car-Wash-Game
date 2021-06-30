using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WrencherTween : MonoBehaviour
{
    public float tweenTime;
    
    // Start is called before the first frame update
    void Start()
    {

        // float time = Random.Range(0.5f , 5);

        LeanTween.moveY(gameObject, -3.45f, 5f)
            .setDelay(1f)
            .setOnComplete(rotate);
    }

    // Update is called once per frame   
    void Update()
    {
        
    }

    void rotate()
    {
        LeanTween.rotate(gameObject, new Vector3(3f, 3f, 3f), tweenTime)
            .setOnComplete(rotateBack);
    }

    void rotateBack()
    {
        LeanTween.rotate(gameObject, new Vector3(-3f, -3f, -1f), tweenTime)
            .setOnComplete(rotate);
    }
}
