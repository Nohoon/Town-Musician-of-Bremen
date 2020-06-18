using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform[] WayPoint;
    Vector3 WayPointPosition;

    int count;
    bool isTrriger;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        isTrriger=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
            ++count;
            
        WayPointPosition=WayPoint[count].position -transform.position;

        transform.position += WayPointPosition.normalized * 3.25f * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isTrriger)
        {
            ++count;
            isTrriger = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
         isTrriger = false;
    }

    
}


