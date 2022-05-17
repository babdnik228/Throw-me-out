using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSetActive : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            panel.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            panel.SetActive(true);
        }
    }
}
