using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 1;
    void Update()
    {
        if (health <= 0) Die();
    }

    void OnTriggerEnter2D()
    {
        health--;
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
