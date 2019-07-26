using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManagment : MonoBehaviour
{

    public Text SkillXP;
    private int SkillValue = 0;
    public Text Healt;
    private int HealtValue = 100;
    void Start()
    {
        SkillXP.text = SkillValue.ToString();
        Healt.text = HealtValue.ToString();
    }
    public void UpdateSkill(int value)
    {
        SkillValue += value;
        SkillXP.text = SkillValue.ToString();
    }
    public void UpdateHealt(int value)
    {
        HealtValue += value;
        Healt.text = HealtValue.ToString();
    }
}