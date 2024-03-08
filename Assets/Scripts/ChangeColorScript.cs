using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeColorScript : MonoBehaviour
{
    public GameObject SoundButton;
    public bool MusicTurnOffandon;
    public GameObject SettingsWinodw;
    public GameObject ShopCWindow;
    public GameObject ShopGWindow;
    public GameObject MainWindow;
    public GameObject PlayWindow;
    public AudioClip sound;
    public GameObject point;
    public GameObject cup;
    public GameObject glider;
   

    
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        button.onClick.AddListener(PlaySound);
    }

    public void PlaySound()
    {
        source.PlayOneShot(sound);
    }


    public void Settings()
    {
        MainWindow.SetActive(false);
        SettingsWinodw.SetActive(true);
        source.PlayOneShot(sound);

    }
    public void ShopC()
    {
        MainWindow.SetActive(false);
        ShopCWindow.SetActive(true);
        source.PlayOneShot(sound);

    }
    public void ShopG()
    {
        MainWindow.SetActive(false);
        ShopGWindow.SetActive(true);
        cup.SetActive(false);
        glider.SetActive(true);
        source.PlayOneShot(sound);

    }
    public void GoToStart()
    {
        MainWindow.SetActive(true);
        SettingsWinodw.SetActive(false);
        ShopCWindow.SetActive(false);
        PlayWindow.SetActive(false);
        ShopGWindow.SetActive(false);
        source.PlayOneShot(sound);
        if (glider==true){ glider.SetActive(false);cup.SetActive(true); }
    }

    public void Play()
    {
        point.SetActive(true);
        PlayWindow.SetActive(true);
        MainWindow.SetActive(false);
        source.PlayOneShot(sound);
    }

    public void Sound()
    {
        if (!MusicTurnOffandon)
        { MusicTurnOffandon = true; AudioListener.volume = 0f ; SoundButton.SetActive(true); }
        else
        { MusicTurnOffandon = false; AudioListener.volume = 1f ; SoundButton.SetActive(false); }


    }

}
