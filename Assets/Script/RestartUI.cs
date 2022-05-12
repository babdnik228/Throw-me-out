using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class RestartUI : MonoBehaviour
{
    public string nameScene;
    public void ClickRestart()
    {
        SceneManager.LoadScene(nameScene);
    }
}
