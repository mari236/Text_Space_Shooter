using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    private float spinSpeed = 90;
    private float meSpeed = 3;
    
    
    void Update()
    {
        //spining
        float z = transform.rotation.eulerAngles.z;
        z += spinSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, z);
        transform.position += vector.up * meSpeed * Time.deltaTime;

       
      
    }

    
}
