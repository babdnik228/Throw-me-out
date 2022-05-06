using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static int ballCount;

    [SerializeField]
    private int ball;
    private void Start()
    {
        ballCount = ball;
    }

    private void Update()
    {
        if(ballCount == 0)
        {
            Debug.Log("Win");
        }
    }
}
