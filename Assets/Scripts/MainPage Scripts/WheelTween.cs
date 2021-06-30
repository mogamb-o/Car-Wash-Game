using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTween : MonoBehaviour
{
    public float tweenTime;
    // Start is called before the first frame update
    void Start()
    {
       //LeanTween.rotate(gameObject, new Vector3(0f,0f,-1200f), tweenTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, -200f) * Time.deltaTime);
        //LeanTween.rotate(gameObject, new Vector3(0f, 0f, -1200f), tweenTime);
    }
}
