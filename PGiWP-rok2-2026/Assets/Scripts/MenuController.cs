using UnityEngine;

public class MenuController : MonoBehaviour
{
    
    public GameObject settingsPanel;

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (settingsPanel != null)
            {
              
                settingsPanel.SetActive(!settingsPanel.activeSelf);
            }
        }
    }
}