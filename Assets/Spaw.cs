using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaw : MonoBehaviour
{
    public float nextTime;
    public float spawn ;
    public GameObject prefab;
   

    private void Start()
    {
        nextTime = Time.time;
    }

    private void Update()
    {
        
        if (Time.time > nextTime)
        {
            spawn = Random.Range(1, 10);
            var pos = transform.position;
            Instantiate(prefab, pos, Quaternion.Euler(0, 0, 0));
            nextTime += spawn;
            
        }
    }
}
