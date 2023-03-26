using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float flySpeed;
    public float rotSpeed;
    public Vector3 pos;
    public Quaternion rot;
    
    void Update()
    {
        //rotation
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z = z - Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        //movement
        pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * flySpeed * Time.deltaTime, 0);
        pos += rot * velocity;
        transform.position = pos;

        //borders
        if(pos.y > 5) pos.y = -4;
        if (pos.y < -4) pos.y = 5;
        if (pos.x > 8) pos.x = -8;
        if (pos.x < -8) pos.x = 8;

        transform.position = pos;

        
    }

     
}
