using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChatLogScript : MonoBehaviour
{
    public GameObject ChatlogCanvas;
    public GameObject menuPanel;    
    public TextboxScript textboxscript;

    public TextMeshProUGUI chatlogtext1;
    public TextMeshProUGUI chatlogtext2;
    public TextMeshProUGUI chatlogtext3;
    public TextMeshProUGUI chatlogtext4;
    public TextMeshProUGUI chatlogtext5;
    public TextMeshProUGUI chatlogtext6;
    public TextMeshProUGUI chatlogtext7;
    public TextMeshProUGUI chatlogtext8;
    public TextMeshProUGUI chatlogtext9;

    // Start is called before the first frame update
    void Start()
    {
        linesclickedrun();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChatlogCanvas.SetActive(false);
            menuPanel.SetActive(true);
        }
    }
    public void linesclickedrun()
    {
        if (textboxscript.line1Ran == true)
        {
            chatlogtext1.text = "HIII";
        }

        if (textboxscript.line2Ran == true)
        {
            chatlogtext2.text = "This is filler text";
        }
        if (textboxscript.line3Ran == true)
        {
            chatlogtext3.text = "can you see this?";
        }
        if (textboxscript.line4Ran == true)
        {
            chatlogtext4.text = "Money for fun!";
        }
        if (textboxscript.line5Ran == true)
        {
            chatlogtext5.text = "GYATTT";
        }
        if (textboxscript.line6Ran == true)
        {
            chatlogtext6.text = "RIZZZ";
        }
        if (textboxscript.line7Ran == true)
        {
            chatlogtext7.text = "Skibidi";
        }
        if (textboxscript.line8Ran == true)
        {
            chatlogtext8.text = "Ok thats it";
        }
        if (textboxscript.line9Ran == true)
        {
            chatlogtext9.text = "This is the final line of text";
        }
    }


}
