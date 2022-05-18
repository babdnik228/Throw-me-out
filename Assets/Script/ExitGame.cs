using UnityEngine;

public class ExitGame : MonoBehaviour
{
   public void ExitGameButton()
    {
        Application.Quit();
    }
    public void DeletAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
