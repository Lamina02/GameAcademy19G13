using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wapon : MonoBehaviour {

    //// Update is called once per frame
    //void Update () {

    //   }
    public Unit unit;
    public GameObject parentObject;
    public GameObject explosion;
    public BoardManager boardmanager;

    //   // Use this for initialization
    void Start()
    {
        boardmanager = GameObject.Find("GameManager").GetComponentInParent<BoardManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Units" && parentObject.tag == "Player")
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);

            Debug.Log(collision.tag + " destroyed by " + parentObject.tag);
            collision.gameObject.GetComponentInChildren<EnnemyScripts>().TakeDamage();
            
        }
        if (collision.tag == "Player" ) // Units"ATTACK VERS UN PLAYER
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            boardmanager.HealtValue -= (int)parentObject.GetComponentInChildren<Unit>().attack;

            Debug.Log(collision.tag+ " attecked by "+ parentObject.tag);
        }

    }
}
