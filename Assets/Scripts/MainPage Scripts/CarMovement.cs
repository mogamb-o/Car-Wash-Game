using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float tweenTime;
    public float punchTime; 
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveX(gameObject, 0.3f, tweenTime)
            .setOnComplete(scale);
    }
    
    void scale()
    {
        LeanTween.scale(gameObject, new Vector3(15f, 5f, 0f), punchTime)
            .setEasePunch()
            .setOnComplete(scale);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
