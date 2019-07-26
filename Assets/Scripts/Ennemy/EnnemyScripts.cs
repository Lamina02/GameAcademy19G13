using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnnemyScripts : MonoBehaviour {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
    public Unit unit;
    private Transform player;
    private BoardManager boardManager;
    private Text ShowScore;
    Animator anim;
    //public string stringToEdit = "";
    public GameObject prefab;


    // Use this for initialization
    void Start()
    {
        boardManager = GameObject.Find("GameManager").GetComponent<BoardManager>();
        player = GameObject.FindWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }
    //void OnGUI()
    //{
    //    // Make a text field that modifies stringToEdit.
    //    stringToEdit = GUI.TextField(new Rect(this.transform.position.x, this.transform.position.y, 200, 20), stringToEdit,25);
    //}
    public void ScoreDisplay(int value)
    {

      //  boardManager.ShortScoreValue = value.ToString();
       // GameObject enemy = GameObject.Instantiate(, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("UI").transform);

        //GameObject text = GameObject.FindGameObjectWithTag("ScoreDisplay");
        //ShowScore = text.GetComponent<Text>();

        //ShowScore.text = unit.XPAfterKill.ToString();
        //ShowScore.gameObject.transform.SetParent(, true); ;

        //ShowScore.text = unit.XPAfterKill.ToString();
        //Destroy(ShowScore, 1);
    }
    public void TakeDamage(int amount = 30)
    {
        unit.Healt -= amount;
        if (unit.Healt <= 0)
        {
            //Instantiate(prefab, transform.position, transform.rotation, GameObject.Find("WorldMap").transform);
            Instantiate(prefab, transform.position, transform.rotation);//, GameObject.Find("WorldMap").transform
            //GameObject.Find("PannelView").GetComponentInChildren<InfoManagment>().UpdateSkill();
            boardManager.PlayerSkillUpdate((int)unit.XPAfterKill);
            ScoreDisplay((int)unit.XPAfterKill);
            unit.UIHitScore();
            //stringToEdit = GUI.Label(new Rect(gameObject.transform.position.x, gameObject.transform.position.y, 200, 20), stringToEdit, 25);
            //stringToEdit = "Dead";
            //Instantiate(score, transform.position, transform.rotation);


            unit.HealBarUpdate();
            GameObject.Destroy(gameObject);
            //bullet.GetComponent<Rigidbody2D>().velocity = transform.up * 5.0f;
        }
        else
        {
            boardManager.PlayerSkillUpdate((int)unit.XPAttack);
            ScoreDisplay((int)unit.XPAttack);
            unit.HealBarUpdate();
            unit.UIHitScore();
            //Instantiate(score, transform.position, transform.rotation);
        }

    }
    public void Attack()
    {

        anim.SetTrigger("Attack");

    }
    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < 3)//player.transform.position <= 
        {
            Attack();
        }
    }
    void FixedUpdate()
    {
        float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
        transform.eulerAngles = new Vector3(0, 0, z);
        //rigidbody2D.angularVelocity = 0;
        Rigidbody2D rigibdy = gameObject.GetComponent("Rigidbody2D") as Rigidbody2D;
        rigibdy.AddForce(gameObject.transform.up * unit.speed);
    }

}
