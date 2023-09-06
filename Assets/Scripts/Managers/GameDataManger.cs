using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManger : MonoBehaviour
{
    public static GameDataManger D;

    [SerializeField] private string _playerName;
    [SerializeField] private string _playerType;
    public List<string> playerTypeList = new List<string> { "Knight", "Penguin" };
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
        i = UnityEngine.Random.Range(0, playerTypeList.Count);
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
        return playerTypeList[i];
    }
}
