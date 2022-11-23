using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touches : MonoBehaviour
{
    public Vector2 minDistance;
    Vector2 oldPosition1;
    Vector2 oldPosition2;
    void Update()
    {
        GetSwipe();
        MultiTouch();
    }
    void GetSwipe()
    {
        if (Input.touchCount > 0)
        {
            Touch touch;
            touch = Input.GetTouch(0);
            if (touch.deltaPosition.x > minDistance.x && touch.deltaPosition.y < minDistance.y && touch.deltaPosition.y > -minDistance.y)
                Debug.Log("Свайп вправо");
            //if (touch.deltaPosition.y > touchPosition.y)
            //    Debug.Log(touch.deltaPosition.y);
            //if (touch.deltaPosition.y < -touchPosition.y)
            //    Debug.Log(touch.deltaPosition.y);
        }
    }
    void MultiTouch()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            //Touch touch2 = Input.GetTouch(1);
            Vector2 currentPosition1 = touch.position;
            Vector2 currentPosition2 = new Vector2(500, 200);
            //Vector2 currentPosition2 = touch2.position;
            float distance = Vector3.Distance(currentPosition1, currentPosition2);
            float oldDisstance = Vector3.Distance(oldPosition1, oldPosition2);
            if (distance > oldDisstance)
                Debug.Log("Жест увеличение");
            oldPosition1 = currentPosition1;
            oldPosition2 = currentPosition2;
        }
    }
}
