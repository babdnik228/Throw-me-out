using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sing_GameManager;

    public static int ballCount;
    [SerializeField]
    private int ball;
    public float _timerGame = 180;
    private void Start()
    {
        sing_GameManager = this;
        ballCount = ball;
    }

    private void Update()
    {
        Result();
        Timer();
    }
    public void Timer()
    {
        _timerGame-=Time.deltaTime; 
        if(_timerGame <= 0)
        {
            _timerGame = 0;
        }
    }
    public void Result()
    {
        if(_timerGame == 0)
        {
            UIManager.sing_UI_Manager.GameObjectSetActiv();
            UIManager.sing_UI_Manager.DefeatResult();
        }
        if(ballCount == 0)
        {
            _timerGame = 1000;
            UIManager.sing_UI_Manager.GameObjectSetActiv();
            UIManager.sing_UI_Manager.VictoryResult();
        }
    }
}
