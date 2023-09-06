using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class JoinBtn : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    
    public void gameStart()
    {
        if (GameDataManger.D != null)
        {
            GameDataManger.D.SetPlayerName(_inputField.text);
        }

        SceneManager.LoadScene("MainScene");
    }
}
