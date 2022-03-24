using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicking : MonoBehaviour
{
    [SerializeField] Button _button;
    [SerializeField] Text _buttonText;
    [SerializeField] string _playerSide;

    GameManager _gameManager;


    public void GameManagerRef(GameManager GameManager)
    {
        _gameManager = GameManager;
    }

    public void SetSpace()
    {
        _buttonText.text = _playerSide;
        _button.interactable = false;
    }
}
