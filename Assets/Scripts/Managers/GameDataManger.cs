using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManger : MonoBehaviour
{
    public static GameDataManger D;

    [SerializeField] private string _playerName;
    [SerializeField] private string _playerType;

    private List<string> _playerTypeList = new List<string> { "Knight", "Penguin", "Wizard" };
    private int i;

    void Awake()
    {
        if (D == null)
        {
            D = this;
            DontDestroyOnLoad(D);
        }
        else
        {
            Destroy(gameObject);
        }
        i = UnityEngine.Random.Range(0, _playerTypeList.Count);
        _playerType = _playerTypeList[i];
    }

    public void SetPlayerName(string playerName)
    {
        _playerName = playerName;
    }

    public string GetPlayerName()
    {
        return _playerName;
    }

    public string GetPlayerType()
    {
        return _playerType;
    }

    public List<string> GetPlayerTypeList()
    {
        return _playerTypeList;
    }
}
