using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScripts : MonoBehaviour
{
    private GameObject parentObject;
    public GameObject explosion;
    public  void start()
    {

        gameObject.GetComponent<Rigidbody2D>().velocity = transform.forward * 5.0f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //parentObject = transform.parent.gameObject;

        if (collision.tag == "Units")
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            //parentObject.GetComponent()
            //Debug.Log(collision.tag + " destroyed by " + parentObject.tag);
            collision.gameObject.GetComponentInChildren<EnnemyScripts>().TakeDamage();


            //Destroy(collision.gameObject);
        }

    }
}
