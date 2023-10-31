using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostmove : MonoBehaviour
{
    public float moveSpeed = 5;


    public float turnSpeed = 5;
   


    // Start is called before the first frame update
    void Start()
    {
    
    }
       
    

    // Update is called once per frame
    void Update()
    {
        //Move Forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
       

        //Rotate
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
