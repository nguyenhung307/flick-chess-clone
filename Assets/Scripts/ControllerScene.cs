using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerScene : MonoBehaviour
{
    public int level;
    public Text CurrentLevel;
    public GameObject Map1, Map2, Map3, MapBonus;


    void Start()
    {
        CurrentLevel.text = level.ToString();

    }

    void Update()
    {

        CurrentLevel.text = level.ToString();
        // PlayerPrefs.SetInt("HighestScore", level);

        // if (level % 5 == 0 && level % 10 != 0)
        // {
        //     // SceneManager.LoadScene(3);
        //     MapBonus.SetActive(true);
        //     Map1.SetActive(false);
        //     Map2.SetActive(false);
        //     Map3.SetActive(false);
        // }
        // if ((level <= 10 && level % 10 == 0 )|| !(level % 5 == 0 ))
        // {
        //     Map1.SetActive(true);
        //     Map2.SetActive(false);
        //     Map3.SetActive(false);
        //     MapBonus.SetActive(false);
        // }
        // if ((level <= 20 && level > 10 && level % 10 == 0 ) || !(level % 5 == 0 ))
        // {
        //     Map2.SetActive(true);
        //     Map1.SetActive(false);
        //     Map3.SetActive(false);
        //     MapBonus.SetActive(false);
        // }
        // if ((level <= 30 && level > 20 && level > 10 && level % 10 == 0 ) || !(level % 5 == 0 ))
        // {
        //     Map2.SetActive(false);
        //     Map1.SetActive(false);
        //     Map3.SetActive(true);
        //     MapBonus.SetActive(false);
        // }
        // if (level == 2)
        // {
        //     SceneManager.LoadScene(1);
        // }

        // if(level == 20)
        // {
        //     SceneManager.LoadScene(1);
        // }
        // if(level == 30)
        // {
        //     SceneManager.LoadScene(2);
        // }
    }
    public void AddLevelButton()
    {
        level += 1;
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
