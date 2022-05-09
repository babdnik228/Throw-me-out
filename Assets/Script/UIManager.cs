using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager sing_UI_Manager;
    [SerializeField] private GameObject _panel_pGame;
    [SerializeField] private GameObject _textGameVictory;
    [SerializeField] private GameObject _textGameDefeat;
    [SerializeField] private Text _timer;
    [SerializeField] private Text _bullet_UI_amount;
    [SerializeField] private int sceneRestart;
    private void Start()
    {
        sing_UI_Manager = this;
    }
    private void Update()
    {
        _timer.text = GameManager.sing_GameManager._timerGame.ToString();
        _bullet_UI_amount.text = Shot.bulletAmount.ToString();
    }
    public void GameObjectSetActiv()
    {
        _panel_pGame.SetActive(true);
    }
    public void VictoryResult()
    {
        _timer.gameObject.SetActive(false);
        _textGameVictory.SetActive(true);
    }
    public void DefeatResult()
    {
        _timer.gameObject.SetActive(false);
        _textGameDefeat.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneRestart);
    }

}
