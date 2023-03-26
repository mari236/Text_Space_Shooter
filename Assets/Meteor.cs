using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    private float spinSpeed = 90;
    private float meSpeed = 3;
    public Spaw spaw;
    public Health health;
    public GameObject prefab;

    
    void Update()
    {
        //spining
       float z = transform.rotation.eulerAngles.z;
        z += spinSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, z);
        transform.position += Vector3.right * meSpeed * Time.deltaTime;

       

        if (health.health == 0)
        {
            float zet = Random.Range(0, 359);
            int t = Random.Range(1, 10);
            for (int i = 0; i >=t; i++)
            {
                var pos = transform.position;
                Instantiate(prefab, pos, Quaternion.Euler(0, 0, zet));
            }
        }

        if(transform.position.x >= 8) Destroy(gameObject);
    }
   
    
}
