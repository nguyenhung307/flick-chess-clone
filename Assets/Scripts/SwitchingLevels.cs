using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchingLevels : MonoBehaviour
{
    private GrapInput grapInput;
    // Storing different levels'
    public GameObject[] levels;
    // Counting current level
    public int current_level = 0;
    

    //Testing

    //
    private void Start()
    {
        current_level = 0;
    }

    
    public void Upgrade()
    {
        // Check if we're safe to upgrade (We haven't reached the last level)
        if (current_level < levels.Length - 1) //minus 1 do lvl 0 là Pawn
        {
            // Switch to the updated level
            SwitchObject(current_level);
        }
    }

    void SwitchObject(int lvl)
    {
        // Count from zero the last level in our array
        
        levels[lvl + 1].transform.position = levels[lvl].transform.position;
        levels[lvl].SetActive(false);
        levels[lvl+1].SetActive(true);
        //Increase level
        current_level++;

    }
}