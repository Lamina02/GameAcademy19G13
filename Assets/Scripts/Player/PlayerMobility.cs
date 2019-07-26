using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {

    //// Use this for initialization

    public BoardManager boardmanager;
    public GameObject bulletPrefab;
    public float defaultSpeed = 10;
    public GameObject WeaponRight;

    enum LastDirection
    {
        LEFT,
        RIGHT,
        FRONT,
        BACK
    }

    LastDirection stateDirection = LastDirection.BACK;

    [SerializeField] Animator anim;

    //public void TakeDamage(int amount = 30)
    //{
    //    healt -= amount;
    //    if (healt <= 0)
    //    {
    //        //GameObject.Destroy(gameObject);
    //        //Instantiate(prefab, transform.position, transform.rotation, GameObject.Find("WorldMap").transform);
    //    }

    //}
    void Start ()
    {
        boardmanager = GameObject.Find("GameManager").GetComponent<BoardManager>();
        //boardmanager = GameObject.Find("PannelView").GetComponentInChildren<BoardManager>();  
    }
    //int score = 0;
    //            TextMesh score3DText;

    //            void OnTriggerEnter(other : Collider ) {

    //                if (other.tag == "50P") { score += 50; scoreText = "Score: " + score; Destroy(other.gameObject); score3DText.text = "Score: " + score.ToString(); }
    //    else if (other.tag == "Enemy") { score += 100; scoreText = "Score: " + score; Destroy(other.gameObject); score3DText.text = "Score: " + score.ToString(); }

    //            }
    //Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("LeftAttack");
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (boardmanager.EnergyValue > 0)
            {
                //Back
                if (Input.GetAxis("Vertical") > 0.0f)
                {
                    anim.Play("AttackAnimationBack");
                }
                //Front
                if (Input.GetAxis("Vertical") < 0.0f)
                {
                    anim.Play("AttackAnimationFront");
                }
                //Right
                if (Input.GetAxis("Horizontal") > 0.0f)
                {
                    anim.Play("AttackAnimationFront");
                }
                //Left
                if (Input.GetAxis("Horizontal") < 0.0f)
                {
                    anim.Play("AttackAnimationFront");
                }

                //anim.SetTrigger("AttackProjectil");
                boardmanager.EnergyValue -= 1;
            GameObject bullet = Instantiate(bulletPrefab, WeaponRight.transform.position, WeaponRight.transform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = WeaponRight.transform.up * 5.0f;

            Destroy(bullet, 1);

             
                //Debug.Log("Test souris click droite");

            }
        }
    }


    void FixedUpdate()
    {
       
        Rigidbody2D rigibdy = gameObject.GetComponent("Rigidbody2D") as Rigidbody2D;

        rigibdy.angularVelocity = 0;

        float inputVertical = Input.GetAxis("Vertical");
        float inputHorizontal= Input.GetAxis("Horizontal");

        //Back
        if (inputVertical > 0.0f)
        {
            stateDirection = LastDirection.BACK;
        }
        //Front
        if (inputVertical < 0.0f)
        {
            stateDirection = LastDirection.FRONT;
        }
        //Right
        if (inputHorizontal > 0.0f)
        {
            stateDirection = LastDirection.RIGHT;
        }
        //Left
        if (inputHorizontal < 0.0f)
        {
            stateDirection = LastDirection.LEFT;
        }

        rigibdy.AddForce(gameObject.transform.up * defaultSpeed * inputVertical);
        rigibdy.AddForce(gameObject.transform.right * defaultSpeed * inputHorizontal);

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
