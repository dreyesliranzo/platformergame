using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 2;

    void Awake()
    {
        Destroy(gameObject, life);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("enemy"))
        {

            Destroy(gameObject);

        }
    Destroy(gameObject);
        
        
    }
}
