using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static int ballCount;

    [SerializeField]
    private int ball;
    [SerializeField] private int _timerGame;
    private void Start()
    {
        ballCount = ball;
    }

    private void Update()
    {
        Timer();
        
    }
    public void Timer()
    {
        _timerGame--; 
    }
    public void Result()
    {
        if(_timerGame == 0)
        {
            UIManager.sing_UI_Manager.DefeatResult();
        }
        if(ballCount == 0)
        {
            UIManager.sing_UI_Manager.VictoryResult();
        }
    }
}
