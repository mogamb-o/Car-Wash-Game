using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSuperCar : MonoBehaviour
{
    public GameObject Wheel1;
    public GameObject Wheel2;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateZ(Wheel1, -45f , 1f);
        LeanTween.rotateZ(Wheel2, -45f, 1f);

        LeanTween.moveX(gameObject, -4f ,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
