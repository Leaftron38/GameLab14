using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroDestruyeBalas : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            Destroy(collision.gameObject);
        }
    }
}
