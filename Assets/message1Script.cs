using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message1Script : MonoBehaviour
{
    public GameObject message1;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(message1, 0 , 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
