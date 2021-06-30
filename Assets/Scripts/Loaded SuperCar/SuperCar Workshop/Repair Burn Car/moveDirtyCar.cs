using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDirtyCar : MonoBehaviour
{
    public GameObject Wheel1;
    public GameObject Wheel2;
    public GameObject grid;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateZ(Wheel1, -700f, 2f);
        LeanTween.rotateZ(Wheel2, -700f, 2f);

        LeanTween.moveX(gameObject, 0f, 2f)
            .setOnComplete(()=> {
                grid.SetActive(true);
            });
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
