using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
    // Start is called before the first frame update
    public int level;
    public Text CurrentLevel;
    public GameObject Map1, Map2, Map3;


    void Start()
    {
        CurrentLevel.text = level.ToString();
        Map1.SetActive(false);
        Map2.SetActive(false);
        Map3.SetActive(false);
    }

    void Update()
    {
        ControllMap();
    }
    public void ControllMap()
    {
        
        CurrentLevel.text = level.ToString();
        PlayerPrefs.SetInt("HighestScore", level);
        
        // if(level  == 0)
        // {
           
        //     Map1.SetActive(false);
        //     Map2.SetActive(false);
        //     Map3.SetActive(false);
        // }
        if(level >= 0 || level < 30)
        {
            // MapBonus.SetActive(false);
            Map1.SetActive(true);
            Map2.SetActive(false);
            Map3.SetActive(false);
        }
        else if(level >= 31 || level < 60)
        {
            // MapBonus.SetActive(false);
            Map1.SetActive(true);
            Map2.SetActive(false);
            Map3.SetActive(false);
        }
        else if(level >= 61 || level < 90)
        {
            // MapBonus.SetActive(false);
            Map1.SetActive(false);
            Map2.SetActive(true);
            Map3.SetActive(false);
        }
        else if(level >= 91 || level < 120)
        {
            // MapBonus.SetActive(false);
            Map1.SetActive(false);
            Map2.SetActive(false);
            Map3.SetActive(true);
        }


    }
    public void AddLevelButton()
    {
        level += 1;
        // SceneManager.LoadScene(0);
    }

    // public void LoadNextScene()
    // {
    //     int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    //     SceneManager.LoadScene(currentSceneIndex + 1);
    // }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
