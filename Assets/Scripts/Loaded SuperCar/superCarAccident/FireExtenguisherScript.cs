using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireExtenguisherScript : MonoBehaviour
{
    [SerializeField] private GameObject fireExtingusher;
    [SerializeField] private GameObject indicator1;
    [SerializeField] private GameObject indicator2;

    // Start is called before the first frame update

    public void enable()
    {
        fireExtingusher.SetActive(true);
        indicator1.SetActive(true);

        LeanTween.scale(indicator1, new Vector3(2f, 2f, 2f), 5f)
            .setEasePunch();

        LeanTween.scale(indicator2, new Vector3(3f, 3f, 3f), 5f)
            .setEasePunch();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
