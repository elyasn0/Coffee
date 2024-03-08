using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//IT JUST WORK
public class SkinChanger : MonoBehaviour
{
    private int activeGlider;
    private int activeSkin;
    public Text describe, describee;
    public GameObject rewardfor0, rewardfor25, rewardfor50, rewardfor75,
        rewardfor100, rewardfor150, rewardfor200, rewardfor250, rewardfor300, rewardfor400, rewardfor500;
    public GameObject rewardfor0pg, rewardfor5pg, rewardfor15pg, rewardfor30pg, rewardfor60pg, rewardfor100pg, rewardfor200pg, rewardfor300pg/*, rewardfor400pg*/;
    public GameObject g0, g5, g15, g30, g60, g100, g200, g300;
    public void Start()
    {
        activeGlider = PlayerPrefs.GetInt("activeGlider", activeGlider);
        activeSkin = PlayerPrefs.GetInt("activeSkin", activeSkin);
        switch (activeGlider)
        {
            case 0:
                G0();
                break;
            case 1:
                G5();
                break;
            case 2:
                G15();
                break;
            case 3:
                G30();
                break;
            case 4:
                G60();
                break;
            case 5:
                G100();
                break;
            case 6:
                G200();
                break;
            case 7:
                G300();
                break;
        }

        switch (activeSkin)
        {
            case 0:
                C0();
                break;
            case 1:
                C25();
                break;
            case 2:
                C50();
                break;
            case 3:
                C75();
                break;
            case 4:
                C100();
                break;
            case 5:
                C150();
                break;
            case 6:
                C200();
                break;
            case 7:
                C250();
                break;
            case 8:
                C300();
                break;
            case 9:
                C400();
                break;
            case 10:
                C500();
                break;
        }
    }
    public void C0()
    {
        rewardfor0.SetActive(true);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "Cup";
        activeSkin = 0;
        Activate();
    }
    public void C25()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(true);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "SupTea";
        activeSkin = 1;
        Activate();
    }
    public void C50()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(true);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "Cup_source";
        activeSkin = 2;
        Activate();


    }
    public void C75()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(true);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "SlaCup";
        activeSkin = 3;
        Activate();


    }
    public void C100()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(true);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "Cupons";
        activeSkin = 4;
        Activate();


    }
    public void C150()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(true);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "51 Cup";
        activeSkin = 5;
        Activate();

    }
    public void C200()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(true);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "Cuppy";
        activeSkin = 6;
        Activate();

    }
    public void C250()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(true);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "Nuke-cup";
        activeSkin = 7;
        Activate();

    }
    public void C300()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(true);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(false);
        describe.text = "Havaycup";
        activeSkin = 8;
        Activate();

    }
    public void C400()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(true);
        rewardfor500.SetActive(false);
        describe.text = "MineCup";
        activeSkin = 9;
        Activate();

    }
    public void C500()
    {
        rewardfor0.SetActive(false);
        rewardfor25.SetActive(false);
        rewardfor50.SetActive(false);
        rewardfor75.SetActive(false);
        rewardfor100.SetActive(false);
        rewardfor150.SetActive(false);
        rewardfor200.SetActive(false);
        rewardfor250.SetActive(false);
        rewardfor300.SetActive(false);
        rewardfor400.SetActive(false);
        rewardfor500.SetActive(true);
        describe.text = "Cupyoda";
        activeSkin = 10;
        Activate();

    }
    public void G0()
    {
        rewardfor0pg.SetActive(true); g0.SetActive(true);
        rewardfor5pg.SetActive(false); g5.SetActive(false);
        rewardfor15pg.SetActive(false); g15.SetActive(false);
        rewardfor30pg.SetActive(false); g30.SetActive(false);
        rewardfor60pg.SetActive(false); g60.SetActive(false);
        rewardfor100pg.SetActive(false); g100.SetActive(false);
        rewardfor200pg.SetActive(false); g200.SetActive(false);
        rewardfor300pg.SetActive(false); g300.SetActive(false);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 0;
        Activate();
        describee.text = "White";
    }
    public void G5()
    {
        rewardfor0pg.SetActive(false); g0.SetActive(false);
        rewardfor5pg.SetActive(true); g5.SetActive(true);
        rewardfor15pg.SetActive(false); g15.SetActive(false);
        rewardfor30pg.SetActive(false); g30.SetActive(false);
        rewardfor60pg.SetActive(false); g60.SetActive(false);
        rewardfor100pg.SetActive(false); g100.SetActive(false);
        rewardfor200pg.SetActive(false); g200.SetActive(false);
        rewardfor300pg.SetActive(false); g300.SetActive(false);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 1;
        Activate();
        describee.text = "Blue";

    }
    public void G15()
    {
        rewardfor0pg.SetActive(false); g0.SetActive(false);
        rewardfor5pg.SetActive(false); g5.SetActive(false);
        rewardfor15pg.SetActive(true); g15.SetActive(true);
        rewardfor30pg.SetActive(false); g30.SetActive(false);
        rewardfor60pg.SetActive(false); g60.SetActive(false);
        rewardfor100pg.SetActive(false); g100.SetActive(false);
        rewardfor200pg.SetActive(false); g200.SetActive(false);
        rewardfor300pg.SetActive(false); g300.SetActive(false);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 2;
        Activate();
        describee.text = "Green";
    }
    public void G30()
    {
        rewardfor0pg.SetActive(false); g0.SetActive(false);
        rewardfor5pg.SetActive(false); g5.SetActive(false);
        rewardfor15pg.SetActive(false); g15.SetActive(false);
        rewardfor30pg.SetActive(true); g30.SetActive(true);
        rewardfor60pg.SetActive(false); g60.SetActive(false);
        rewardfor100pg.SetActive(false); g100.SetActive(false);
        rewardfor200pg.SetActive(false); g200.SetActive(false);
        rewardfor300pg.SetActive(false); g300.SetActive(false);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 3;
        Activate();
        describee.text = "Purple";
    }
    public void G60()
    {
        rewardfor0pg.SetActive(false); g0.SetActive(false);
        rewardfor5pg.SetActive(false); g5.SetActive(false);
        rewardfor15pg.SetActive(false); g15.SetActive(false);
        rewardfor30pg.SetActive(false); g30.SetActive(false);
        rewardfor60pg.SetActive(true); g60.SetActive(true);
        rewardfor100pg.SetActive(false); g100.SetActive(false);
        rewardfor200pg.SetActive(false); g200.SetActive(false);
        rewardfor300pg.SetActive(false); g300.SetActive(false);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 4;
        Activate();
        describee.text = "2020";
    }
    public void G100()
    {
        rewardfor0pg.SetActive(false); g0.SetActive(false);
        rewardfor5pg.SetActive(false); g5.SetActive(false);
        rewardfor15pg.SetActive(false); g15.SetActive(false);
        rewardfor30pg.SetActive(false); g30.SetActive(false);
        rewardfor60pg.SetActive(false); g60.SetActive(false);
        rewardfor100pg.SetActive(true); g100.SetActive(true);
        rewardfor200pg.SetActive(false); g200.SetActive(false);
        rewardfor300pg.SetActive(false); g300.SetActive(false);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 5;
        Activate();
        describee.text = "CD";
    }
    public void G200()
    {
        rewardfor0pg.SetActive(false); g0.SetActive(false);
        rewardfor5pg.SetActive(false); g5.SetActive(false);
        rewardfor15pg.SetActive(false); g15.SetActive(false);
        rewardfor30pg.SetActive(false); g30.SetActive(false);
        rewardfor60pg.SetActive(false); g60.SetActive(false);
        rewardfor100pg.SetActive(false); g100.SetActive(false);
        rewardfor200pg.SetActive(true); g200.SetActive(true);
        rewardfor300pg.SetActive(false); g300.SetActive(false);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 6;
        Activate();
        describee.text = "Donut";
    }
    public void G300()
    {
        rewardfor0pg.SetActive(false); g0.SetActive(false);
        rewardfor5pg.SetActive(false); g5.SetActive(false);
        rewardfor15pg.SetActive(false); g15.SetActive(false);
        rewardfor30pg.SetActive(false); g30.SetActive(false);
        rewardfor60pg.SetActive(false); g60.SetActive(false);
        rewardfor100pg.SetActive(false); g100.SetActive(false);
        rewardfor200pg.SetActive(false); g200.SetActive(false);
        rewardfor300pg.SetActive(true); g300.SetActive(true);
        /*rewardfor400pg.SetActive(true);g400.SetActive(false);*/
        activeGlider = 7;
        Activate();
        describee.text = "Pizza";
    }
    /* public void G400()
     {
         rewardfor0pg.SetActive(false);
         rewardfor5pg.SetActive(false);
         rewardfor15pg.SetActive(false);
         rewardfor30pg.SetActive(false);
         rewardfor60pg.SetActive(false);
         rewardfor100pg.SetActive(false);
         rewardfor200pg.SetActive(false);
         rewardfor300pg.SetActive(false);
         /rewardfor400pg.SetActive(true);
     }*/
     
     public void Activate()
    {
        PlayerPrefs.SetInt("activeSkin", activeSkin);
        PlayerPrefs.SetInt("activeGlider", activeGlider);
    }
}
