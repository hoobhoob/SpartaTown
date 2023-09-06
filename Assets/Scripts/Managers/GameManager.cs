using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEditor.U2D.Aseprite;

public class GameManager : MonoBehaviour
{
    public static GameManager M;

    [SerializeField] private TMP_Text _playerNameTxt;

    [SerializeField] private GameObject _playerParent;
    [SerializeField] private string _playerType;

    private void Awake()
    {
        if (GameDataManger.D != null)
        {
            _playerNameTxt.text = GameDataManger.D.GetPlayerName();
            _playerType = GameDataManger.D.GetPlayerType();
            foreach(string s in GameDataManger.D.playerTypeList)
            {
                GameObject _player = _playerParent.transform.Find(s).gameObject;
                if (s == _playerType)
                    _player.SetActive(true);
                else
                    _player.SetActive(false);
                
            }
        }
        else
        {
            _playerNameTxt.text = "Chad";
            _playerType = "Wizard";
        }
    }

    void Update()
    {
        
    }

    public string GetPlayerType()
    {
        return _playerType;
    }
}
