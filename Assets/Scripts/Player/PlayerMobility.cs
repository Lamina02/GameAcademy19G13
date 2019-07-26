using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {

    //// Use this for initialization

    public float speed;
    public float healt;
    public float skillXP;

    public GameObject bulletPrefab;

    Animator anim;

    public void TakeDamage(int amount = 30)
    {
        healt -= amount;
        if (healt <= 0)
        {
            //GameObject.Destroy(gameObject);
            //Instantiate(prefab, transform.position, transform.rotation, GameObject.Find("WorldMap").transform);
        }

    }
    void Start () {
        anim = GetComponent<Animator>();
    }
    //Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("LeftAttack");
        }
        if (Input.GetMouseButtonDown(1))
        {
            
            //anim.SetTrigger("AttackProjectil");
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = transform.up * 5.0f;
            Destroy(bullet, 1);

            //Debug.Log("Test souris click droite");
        }
    }
    void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition,
                                                 Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        //rigidbody2D.angularVelocity = 0;
        Rigidbody2D rigibdy = gameObject.GetComponent("Rigidbody2D") as Rigidbody2D;

        rigibdy.angularVelocity = 0;
        float input = Input.GetAxis("Vertical");

        rigibdy.AddForce(gameObject.transform.up * speed * input);
        
    }
    //void OnTriggerEnter(Collider c)
    //{
    //    if (c.gameObject.tag == "Objects")
    //        Debug.Log("object collected");
    //    else
    //        Debug.Log("Something else collected");
    //}
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Objects"))
        {
            //other.gameObject.SetActive(false);
        }
    }
}
