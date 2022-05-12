using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] private string nameScene;
    public void LoadLevelButton()
    {
        SceneManager.LoadScene(nameScene);
    }
}
