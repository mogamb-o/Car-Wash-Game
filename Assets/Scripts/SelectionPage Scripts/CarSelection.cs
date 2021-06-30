//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class CarSelection : MonoBehaviour
//{
//    [SerializeField] private Button previousButton;
//    [SerializeField] private Button nextButton;
//    private int currentCar;


//    private void SelectCar(int index)
//    {   //Disable the previous button when we are on first car
//        previousButton.interactable = (index != 0);

//        Disable the next button when we are on last car
//        nextButton.interactable = (index != transform.childCount - 1);

//        Process all child object of current transform
//        for (int i = 0; i < transform.childCount; i++)
//        {
//            It will only activate those child which we need
//            transform.GetChild(i).gameObject.SetActive(i == index);
//        }
//    }

//    public void ChangeCar(int change)
//    {
//        currentCar += change;
//        SelectCar(currentCar);
//    }
//}
