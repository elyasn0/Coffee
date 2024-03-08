using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency  : Scorepoint
{
    public Text currencytext;
    public Text describe;
    public AudioClip sound;
    public Button Button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        highscint = PlayerPrefs.GetInt("hightscore", highscint);
        currencytext.text = highscint + "";
        source.PlayOneShot(sound);
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        Button.onClick.AddListener(PlaySound);
        
    }
    
    public void OnEnterShop()
    {
        //yep, i know. Don't judge me. I'm not a programmer c:
        if (highscint >= 500)
        { u500.SetActive(false); }
        if (highscint >= 400)
        { u400.SetActive(false); }
        if (highscint >= 300)
        { u300.SetActive(false); }
        if (highscint >= 250)
        { u250.SetActive(false); }
        if (highscint >= 200)
        { u200.SetActive(false); }
        if (highscint >= 150)
        { u150.SetActive(false); }
        if (highscint >= 100)
        { u100.SetActive(false); }
        if (highscint >= 75)
        { u75.SetActive(false); }
        if (highscint >= 50)
        { u50.SetActive(false); }
        if (highscint >= 25)
        { u25.SetActive(false); }
    }
    public void PlaySound()
    {
        source.PlayOneShot(sound);
    }


    public GameObject u25, u50, u75, u100, u150, u200, u250, u300, u400, u500;
    
    public void B25() { describe.text = "You need 25 cups to unlock"; }
    public void B50() { describe.text = "You need 50 cups to unlock"; }
    public void B75() {  describe.text = "You need 75 cups to unlock"; }
    public void B100() {  describe.text = "You need 100 cups to unlock"; }
    public void B150() { describe.text = "You need 150 cups to unlock"; }
    public void B200() {  describe.text = "You need 200 cups to unlock"; }
    public void B250() { describe.text = "You need 250 cups to unlock"; }
    public void B300() {  describe.text = "You need 300 cups to unlock"; }
    public void B400() {describe.text = "You need 400 cups to unlock"; }
    public void B500() {describe.text = "You need 500 cups to unlock"; }
    
    public void M() { highscint += 100; currencytext.text = highscint + ""; PlayerPrefs.SetInt("hightscore", highscint); }
    public void D() { highscint =0; currencytext.text = highscint + ""; PlayerPrefs.SetInt("hightscore", highscint); }

}
