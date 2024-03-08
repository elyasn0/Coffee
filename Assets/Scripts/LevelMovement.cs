using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMovement : MonoBehaviour
{
    public Text leveltext;
    int index;
    int level;
    public float speed;
    public GameObject levelbeforethat;
    public GameObject CurrentLevel;
    public GameObject EndPoint;
    public GameObject[] levels;
    
    

    void Update()
    {
        CurrentLevel.transform.position = CurrentLevel.transform.position + new Vector3(-speed, 0f, 0f) * Time.deltaTime;
        if (CurrentLevel.transform.position.x < EndPoint.transform.position.x) { level++; Debug.Log("New level " + level); Nextlevel(); }
    }
  
    public void Nextlevel()
    {
        if (index < levels.Length)
        {
            CurrentLevel.SetActive(false);
            // if (level % 2 != 0)                 для выключения лвла через 1
            //  {
            //    CurrentLevel.SetActive(false);
            // }
            index = Random.Range(0, levels.Length);
            CurrentLevel = levels[index];
            CurrentLevel.SetActive(true);
            
           
        }
    }
}
