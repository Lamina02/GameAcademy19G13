using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManagment : MonoBehaviour
{
    public BoardManager BoardManager;
    //public Image HealtBar;
    //public Image EnergyBar;
    //public GameObject HealtBar;
    public Text SkillXP;
    public Text Healt;
    public Text Energy;
    void Start()
    {
        SkillXP.text = BoardManager.SkillValue.ToString();
        //HealtBar.fillAmount = BoardManager.HealtValue;
        Healt.text = BoardManager.HealtValue.ToString();
        //EnergyBar.fillAmount = BoardManager.EnergyValue;
        Energy.text = BoardManager.EnergyValue.ToString();
    }
    public void UpdateSkill()
    {
        SkillXP.text = BoardManager.SkillValue.ToString();
    }
    public void UpdateHealt()
    {
        Healt.text = BoardManager.HealtValue.ToString();
    }

    void Update()
    {
        SkillXP.text = BoardManager.SkillValue.ToString();
        Healt.text = BoardManager.HealtValue.ToString();
        Energy.text = BoardManager.EnergyValue.ToString();
    }
}
