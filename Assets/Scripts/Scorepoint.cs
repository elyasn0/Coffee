using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Scorepoint : MonoBehaviour
{
    public bool s;
	public float speed;
    public int highscint;
    public Text highsc;
	public Text scoretext;
	public GameObject point;
    public GameObject ty;


    private void Start()
    {
        highscint = PlayerPrefs.GetInt("hightscore", highscint);
        highsc.text = highscint + "";
    }
    public void Caas() { s = true; }
    void Update()
    {
        if (s) {
            if ((int)point.transform.position.x >= highscint)
            {
                highscint = (int)point.transform.position.x;
                PlayerPrefs.SetInt("hightscore", highscint);
            }
            point.transform.position = point.transform.position + new Vector3(speed, 0f, 0f) * Time.deltaTime;
            scoretext.text = "" + (int)point.transform.position.x;
            if ((int)point.transform.position.x == 100) { ty.SetActive(true); }
        }
	}
}
