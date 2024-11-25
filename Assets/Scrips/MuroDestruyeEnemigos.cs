using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroDestruyeEnemigos : MonoBehaviour
{
    public Animator player;
    public GameObject Explosion;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            
            Destroy(collision.gameObject);
            Destroy(player);
        }
    }

}
