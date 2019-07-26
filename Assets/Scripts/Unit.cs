using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{

    public float speed = 4;
    public float Healt = 100;
    public float attack = 1;
    public float defend = 1;
    public float XPAfterKill = 10;
    public float XPAttack = 3;
    public Image healthBarGreen;
    public Text hitScore;
    public void HealBarUpdate()
    {

        healthBarGreen.fillAmount = 1.0f / 100 * Healt;

    }
    public void UIHitScore()
    {
        StartCoroutine(AttackXPShow());
    }
    IEnumerator AttackXPShow()
    {
        hitScore.text = XPAttack.ToString();
        yield return new WaitForSeconds(0.1f);
        hitScore.text = "";
    }

}
