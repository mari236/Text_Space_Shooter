using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public float nextTime;
    public float angle;
    public float spawnTime;

    void Start()
    {
        nextTime = Time.time;
    }
    void Update()
    {
        

        if(Time.time > nextTime)
        {
            Instantiate(prefab, transform.position, Quaternion.Euler(0, 0, angle);

            nextTime += spawnTime;
        }
    }
}
