using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfaObstacle : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(Logic());
    }

    private IEnumerator Logic()
    {
        while(true)
        {
        yield return new WaitForSeconds(3f);
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(3f);
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<CircleCollider2D>().enabled = true;
        }
        
    }
}
