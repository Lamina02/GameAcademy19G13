using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    //private GameObject parentObject;
    public GameObject explosion;
    public void Collect()
    {

        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateSkill(2);
        GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateHealt(3);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //parentObject = transform.parent.gameObject;

        //if (collision.tag == "Units" && parentObject.tag == "Player")
        //{
        //    //Instantiate(explosion, collision.transform.position, Quaternion.identity);
        //    ////parentObject.GetComponent()
        //    //Debug.Log(collision.tag + " destroyed by " + parentObject.tag);
        //    //collision.gameObject.GetComponentInChildren<EnnemyScripts>().TakeDamage();


        //    //Destroy(collision.gameObject);
        //}
        if (collision.gameObject.tag == "Player") /// ObjectForCollect&& transform.parent.gameObject.tag == "Units"ATTACK VERS UN PLAYER
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);

            //GameObject.Find("Player").GetComponentInChildren<PlayerMobility>().skillXP++;
            GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateSkill(2);
            GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateHealt(3);

            Debug.Log(collision.tag + " à collecter un object");
            Destroy(gameObject);
        }

    }
}
