using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockableSystem : MonoBehaviour
{
    public int _level = 0;
    public int _indexUnlockLevel = 0;
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
    public void UnlockMap(int level)
    {
        if (level > _levelNeedToUnlockArenas[_indexUnlockLevel])
        {
           
            if (_indexUnlockLevel < _levelNeedToUnlockArenas.Count-1)
            {
               
                UpdateUnlockedMaps(_indexUnlockLevel);
                _indexUnlockLevel += 1;
            }
               
        }
    }
    public void UpdateUnlockedMaps(int levelIndex)
    {
        bool changeArena = false;
        int changeArenaIndex = -1;
        Transform arena = _arenasLocked[levelIndex];
        for(int i = 0; i < _arenasInUsed.Count; i++)
        {
            Debug.Log(arena.tag);
            if (arena.tag == _tagArenasInUsed[i])
            {
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
            _arenasInUsed.Add(arena);
            _tagArenasInUsed.Add(arena.tag);
        }
    }
}
