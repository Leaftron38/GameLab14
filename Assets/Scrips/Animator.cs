using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _body2d;
    private float horizotal;
    private float vertical;
    public float velocidad;
    public GameObject bullet;
    public AudioSource sfxManager;
    public GameObject Explosion;
    // Start is called before the first frame update
    void Awake()
    {
        _body2d = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        horizotal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if(Input.GetButtonDown("Fire1") == true)
        {
            Shoot();
            sfxManager.Play();
        }
    }
    void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
    void FixedUpdate()
    {
        _body2d.velocity = new Vector2(horizotal * velocidad, vertical * velocidad);

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

}
