using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockableSystem : MonoBehaviour
{
    public int _level = 0;
    private int _indexUnlockLevel = 0;
    //enum ArenaType { Square,Box,Circle};
    [SerializeField] List<Transform> _arenasLocked;
    [SerializeField] List<string> _tagArenasInUsed;
    [SerializeField] List<Transform> _arenasInUsed;
    [SerializeField] List<int> _levelNeedToUnlockArenas;
    [SerializeField] List<Transform> _newModel;
    [SerializeField] List<int> _levelNeedToUnlockNewModel;
    [SerializeField] List<Transform> Model;
    private void Update()
    {
        UnlockMap(_level);
    }
    public void UnlockAllBasedOnLevel(int level)
    {
        for (int i = 0;i<level; i++)
        {
            UnlockMap(level);
        }
    }
    public void UnlockMap(int level)
    {
        if (_indexUnlockLevel < _levelNeedToUnlockArenas.Count)
        {
            if (level == _levelNeedToUnlockArenas[_indexUnlockLevel])
             {
           
                UpdateUnlockedMaps(_indexUnlockLevel);
                _indexUnlockLevel += 1;
            }
        }
    }
    private void UpdateUnlockedMaps(int levelIndex)
    {
        bool changeArena = false;
        int changeArenaIndex = -1;
        Transform arena = _arenasLocked[levelIndex];
        for(int i = 0; i < _arenasInUsed.Count; i++)
        {
            Debug.Log(arena.tag);
            if (arena.tag == _tagArenasInUsed[i])
            {
                // change using arena of the same tag
                changeArena = true;
                changeArenaIndex = i;
            }
        }
        if (changeArena == true)
        {
            _arenasInUsed[changeArenaIndex] = arena;
        }
        else
        {
            // add arena with its tag if not changing arena of the same tag
            _arenasInUsed.Add(arena);
            _tagArenasInUsed.Add(arena.tag);
        }
    }
}
