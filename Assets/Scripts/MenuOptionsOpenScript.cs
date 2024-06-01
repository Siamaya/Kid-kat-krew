using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuOptionsOpenScript : MonoBehaviour
{
    public Button settingButton;
    public Button chatLogButton;
    public Button mainMenuButton;

    public GameObject menuPanel;
    public GameObject settingsCanvas;
    public GameObject chatLogCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SettingsButtonclick()
    {
        menuPanel.SetActive(false);
        settingsCanvas.SetActive(true);
        Debug.Log("Settings button cliked");
    }
    public void ChatLogButtonclick()
    {
        menuPanel.SetActive(false);
        chatLogCanvas.SetActive(true);
        
    }
    public void MainMenuButtonclick()
    {
        menuPanel.SetActive(false);
        
        Debug.Log("main menu button clikced");
    }
}
