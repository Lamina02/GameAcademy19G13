using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wapon : MonoBehaviour {

    //// Update is called once per frame
    //void Update () {

    //   }
    public GameObject parentObject;
    public GameObject explosion;
    public BoardManager boardmanager;

    //   // Use this for initialization
    void Start()
    {
        boardmanager = GameObject.Find("PannelView").GetComponentInParent<BoardManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        parentObject = transform.parent.gameObject.transform.parent.gameObject;

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
            boardmanager.HealtValue += 2;
            //GameObject.Find("Player").GetComponentInChildren<PlayerMobility>().TakeDamage(1);

            //GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateSkill(2);
            //GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateHealt(-1);
            Debug.Log(collision.tag+ " attecked by "+ parentObject.tag);
            //Destroy(collision.gameObject);
        }

    }
}
