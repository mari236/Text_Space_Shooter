using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shootin : MonoBehaviour
{
    public float coolDown;
    public GameObject bulletPrefab;
    public PlayerMovement player;
 
    

    
    void Update()
    {
        coolDown += Time.deltaTime;
       

        if(Input.GetKey(KeyCode.Space) && coolDown > 0)
        {  
            coolDown -= Time.deltaTime * 2 ;
            var pos = player.pos;
            var rot = player.rot;

            Instantiate(bulletPrefab, pos, rot);

            if (pos.y > 5) Destroy(gameObject);
            if (pos.y < -4) Destroy(gameObject);
            if (pos.x > 8) Destroy(gameObject);
            if (pos.x < -8) Destroy(gameObject);


        }
    }
}
