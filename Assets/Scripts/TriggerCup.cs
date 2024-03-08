using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCup : MonoBehaviour
{
    [SerializeField] private Animator CupAni;
    public GameObject losescreen;
    public BoxCollider2D zone;
    public bool alreadyseen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "KillTag")
        {
           // Time.timeScale = 0.5f;
            zone.enabled = false;
            CupAni.SetBool("LosePar", true);
            StartCoroutine(Delay());
            Delay();
            
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        if (alreadyseen==true) {
        Time.timeScale = 0;
        losescreen.SetActive(true);
            alreadyseen = false;
        }
        else SceneManager.LoadScene("SampleScene");

    }
    IEnumerator Wer() { yield return new WaitForSeconds(5f);zone.enabled=true;  }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void Continue()
    {
        //*GoogleAD*
        CupAni.SetBool("LosePar", false);
        losescreen.SetActive(false);
        CupAni.SetBool("ConPar", true);
        Time.timeScale = 1;
        StartCoroutine(Wer());
    }
}
