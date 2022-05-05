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
    int current_level = 0;
    private void Start()
    {
        grapInput = new GrapInput();
        grapInput.Mouse.Enable();
        grapInput.Mouse.LeftClick.started += OnLeftClick;
    }

    private void OnLeftClick(InputAction.CallbackContext obj)
    {
        current_level += 1;
        SwitchObject(current_level);
    }

    public void Upgrade()
    {
        // Check if we're safe to upgrade (We haven't reached the last level)
        if (current_level < levels.Length - 1)
        {
            // Increase current level
            current_level++;
            // Switch to the updated level
            SwitchObject(current_level);
        }
    }

    void SwitchObject(int lvl)
    {
        // Count from zero the last level in our array
        for (int i = 0; i < levels.Length; i++)
        {
            // Check if we're in the desired level, then activate
            if (i == lvl)
                levels[i].SetActive(true);
            else
                //Otherwise, hdie it
                levels[i].SetActive(false);
        }
    }
}