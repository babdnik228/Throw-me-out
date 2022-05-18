using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] button_Level;
     int level_on_lock;
    private void Start()
    {
        level_on_lock = PlayerPrefs.GetInt("level", 1);
        for (int i = 0; i < button_Level.Length; i++)
        {
            button_Level[i].interactable = false;
        }
        for (int i = 0; i < level_on_lock; i++)
        {
            button_Level[i].interactable = true;
        }
    }
    public void LevelIndex(int indexLevel)
    {
        SceneManager.LoadScene(indexLevel);
    }
}
