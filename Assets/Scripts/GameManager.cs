using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text[] _texts;

    void Awake()
    {
        GameManagerRef();
    }

    void GameManagerRef()
    {
        for (int i = 0; i < _texts.Length; i++)
        {
            _texts[i].GetComponentInParent<Clicking>().GameManagerRef(this);
        }
    }

    public string GetPlayerSide()
    {
        return "?";
    }

    public void EndTurn()
    {
        Debug.Log("EndTurn is not implemented!");
    }
}


