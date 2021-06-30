using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
//[RequireComponent(typeof(BoxCollider))]

public class IndiDragthree : MonoBehaviour
{
    public GameObject objindi;
    public GameObject anotherobjIndi;
    public GameObject Tool;
    public GameObject TrigObj;
    //private Vector3 screenPoint;
    private Vector3 offset;
	public  event Action ActionDownEvent ;
	public  event Action ActionMoveEvent ;
	public  event Action ActionUpEvent ;

    //On action down of the sprite/gameobject .
    void OnMouseDown()
    {

        if (GameManager.Instance.IndiDrag == true)
        {
            offset = gameObject.transform.position -
                    Camera.main.ScreenToWorldPoint(
                        new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            Cursor.visible = true;
            if (ActionDownEvent != null)
                ActionDownEvent();
            GameManager.Instance.is_old_position = gameObject.transform.position;

            objindi.SetActive(false);
            anotherobjIndi.SetActive(true);
            Tool.SetActive(false);
            TrigObj.SetActive(true);

            //transform.SetAsLastSibling();
            //if (transform.name=="Fruit")
            //{
            //    objindi.SetActive(false);

            //}
        }
    }
    //On action drag of the sprite/gameobject .
    void OnMouseDrag() {
        if (GameManager.Instance.IndiDrag == true)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;


            if (ActionMoveEvent != null)
                ActionMoveEvent();

        }
	}
    //On action up of the sprite/gameobject .
    void OnMouseUp()
    {
        if (GameManager.Instance.IndiDrag == true)
        {
           
            Cursor.visible = true;

            if (ActionUpEvent != null)
                ActionUpEvent();
            gameObject.transform.position = GameManager.Instance.is_old_position;
            objindi.SetActive(true);
            anotherobjIndi.SetActive(false);
            //transform.SetAsFirstSibling();
            Tool.SetActive(true);
            TrigObj.SetActive(false);
        }
    }
}
