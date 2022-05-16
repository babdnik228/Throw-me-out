using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] private Vector3 targetPos;
    [SerializeField] private float speed_Obstacle;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed_Obstacle * Time.deltaTime);
        if(targetPos == transform.position)
        {
            targetPos = RandomMove();
        }
    }
    private Vector3 RandomMove()
    {
        Vector3 randomPos = new Vector3();
        randomPos.x = Random.Range(-4, 4);
        randomPos.y = Random.Range(-4, 4);
        randomPos.z = 0;
        return randomPos;
    }
}
