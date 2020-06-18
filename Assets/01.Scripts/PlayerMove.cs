using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform[] WayPoint;
    Vector3 dir;
    CharacterController character;
    int count;
    bool isTrriger;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        isTrriger=false;
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(WayPoint[count]);
            
        //dir=WayPoint[count].position -transform.position;
        //transform.position += dir.normalized * 1.25f * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isTrriger)
        {
           // ++count;
           // isTrriger = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
         isTrriger = false;
    }

    
}


