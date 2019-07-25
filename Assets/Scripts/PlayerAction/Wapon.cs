using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wapon : MonoBehaviour {

    //   // Use this for initialization
    //   void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //   }
    private GameObject parentObject;
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        parentObject = transform.parent.gameObject;

        if (collision.tag == "Units" && parentObject.tag == "Player")
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            //parentObject.GetComponent()
            Debug.Log(collision.tag + " destroyed by " + parentObject.tag);
            collision.gameObject.GetComponentInChildren<EnnemyScripts>().TakeDamage();


            //Destroy(collision.gameObject);
        }
        if (collision.tag == "Player" ) /// && transform.parent.gameObject.tag == "Units"ATTACK VERS UN PLAYER
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);

            GameObject.Find("Player").GetComponentInChildren<PlayerMobility>().TakeDamage(1);

            GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateSkill(2);
            GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateHealt(-1);
            Debug.Log(collision.tag+ " attecked by "+ parentObject.tag);
            //Destroy(collision.gameObject);
        }

    }
}
