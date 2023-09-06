using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinBtn : MonoBehaviour
{
    private InputField _inputField;

    public void gameStart()
    {
        if (GameDataManger.D != null)
        {
            GameDataManger.D.SetPlayerName(_inputField.text);
        }

        SceneManager.LoadScene("MainScene");
    }
}
