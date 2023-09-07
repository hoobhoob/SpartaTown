using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private Button _joinButton;
    [SerializeField] private Button _characterSelectButton;
    [SerializeField] private Button _selectKnight;
    [SerializeField] private Button _selectPenguin;
    [SerializeField] private Button _selectWizard;
    [SerializeField] private GameObject _characterSelectPanel;

    private string _playerType = "Knight";
    private Vector3 _imagePosition;

    public void Start()
    {
        _imagePosition = _characterSelectButton.transform.Find("Image").GetComponent<Image>().transform.position;
    }
    public void OpenCharacterSelectPanel()
    {
        _characterSelectPanel.SetActive(true);
    }

    public void SelectKnight()
    {
        _playerType = "Knight";
        Sprite sprite = _selectKnight.transform.Find("Image").GetComponent<Image>().sprite;
        _characterSelectButton.transform.Find("Image").GetComponent<Image>().sprite = sprite;
        Image image = _characterSelectButton.transform.Find("Image").GetComponent<Image>();
        RectTransform rect = (RectTransform)image.transform;
        rect.sizeDelta = new Vector2(150f, 250f);
        image.transform.position = _imagePosition;
        _characterSelectPanel.SetActive(false);
    }

    public void SelectPenguin()
    {
        _playerType = "Penguin";
        Sprite sprite = _selectPenguin.transform.Find("Image").GetComponent<Image>().sprite;
        _characterSelectButton.transform.Find("Image").GetComponent<Image>().sprite = sprite;
        Image image = _characterSelectButton.transform.Find("Image").GetComponent<Image>();
        RectTransform rect = (RectTransform)image.transform;
        rect.sizeDelta = new Vector2(400f, 400f);
        image.transform.position = _imagePosition + new Vector3(0f, 20f, 0f);
        _characterSelectPanel.SetActive(false);
    }
    public void SelectWizard()
    {
        _playerType = "Wizard";
        Sprite sprite = _selectWizard.transform.Find("Image").GetComponent<Image>().sprite;
        _characterSelectButton.transform.Find("Image").GetComponent<Image>().sprite = sprite;
        Image image = _characterSelectButton.transform.Find("Image").GetComponent<Image>();
        RectTransform rect = (RectTransform)image.transform;
        rect.sizeDelta = new Vector2(150f, 250f);
        image.transform.position = _imagePosition;
        _characterSelectPanel.SetActive(false);
    }

    public void GameStart()
    {
        if (GameDataManger.D != null)
        {
            GameDataManger.D.SetPlayerName(_inputField.text);
            GameDataManger.D.SetPlayerType(_playerType);
        }

        SceneManager.LoadScene("MainScene");
    }
}
