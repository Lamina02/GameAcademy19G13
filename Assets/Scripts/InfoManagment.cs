using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManagment : MonoBehaviour
{
    public BoardManager BoardManager;
    public Text SkillXP;
    public Text Healt;
    void Start()
    {
        SkillXP.text = BoardManager.SkillValue.ToString();
        Healt.text = BoardManager.HealtValue.ToString();
    }
    public void UpdateSkill()
    {
        SkillXP.text = BoardManager.SkillValue.ToString();
        Healt.text = BoardManager.HealtValue.ToString();
    }
    public void UpdateHealt()
    {
        SkillXP.text = BoardManager.SkillValue.ToString();
        Healt.text = BoardManager.HealtValue.ToString();
    }
}
