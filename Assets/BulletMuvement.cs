using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMuvement : MonoBehaviour
{
    float bulletSpeed = 5f;


    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, bulletSpeed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;



        if (pos.y > 5) Destroy(gameObject);
        if (pos.y < -4) Destroy(gameObject);
        if (pos.x > 8) Destroy(gameObject);
        if (pos.x < -8) Destroy(gameObject);


    }
}
