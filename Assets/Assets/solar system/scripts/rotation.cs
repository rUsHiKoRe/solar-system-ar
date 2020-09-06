using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationspeed;
    public float dampamt;

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate((Vector3.up*rotationspeed) * (Time.deltaTime * dampamt),Space.Self); 
    }
}
