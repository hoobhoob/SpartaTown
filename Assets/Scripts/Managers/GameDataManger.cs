using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManger : MonoBehaviour
{
    public static GameDataManger D;

    private string _playerName;

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
    }

    public void SetPlayerName(string playerName)
    {
        _playerName = playerName;
    }
    public string GetPlayerName()
    {
        return _playerName;
    }
}
