
using UnityEngine;

public class SwiftUI : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsPanel;
    [SerializeField] private GameObject panelActivator;
    public void DisablePanel()
    {
        for (int i = 0; i < objectsPanel.Length; i++)
        {
            objectsPanel[i].SetActive(false);
            panelActivator.SetActive(true);
        }
    }
    
}
