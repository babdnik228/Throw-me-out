using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager sing_UI_Manager;
    [SerializeField] private GameObject _panel_pGame;
    [SerializeField] private GameObject _textGameVictory;
    [SerializeField] private GameObject _textGameDefeat;
    private void Start()
    {
        sing_UI_Manager = this;
    }
    public void GameObjectSetActiv()
    {
        _panel_pGame.SetActive(true);
    }
    public void VictoryResult()
    {
        _textGameVictory.SetActive(true);
    }
    public void DefeatResult()
    {
        _textGameDefeat.SetActive(true);
    }

}
