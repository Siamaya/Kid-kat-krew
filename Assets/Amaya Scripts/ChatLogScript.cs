using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
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
    public TextMeshProUGUI chatlogtext10;
    public TextMeshProUGUI chatlogtext11;
    public TextMeshProUGUI chatlogtext12;
    public TextMeshProUGUI chatlogtext13;
    public TextMeshProUGUI chatlogtext14;
    public TextMeshProUGUI chatlogtext15;
    public TextMeshProUGUI chatlogtext16;
    public TextMeshProUGUI chatlogtext17;
    public TextMeshProUGUI chatlogtext18;
    public TextMeshProUGUI chatlogtext19;
    public TextMeshProUGUI chatlogtext20;
    public TextMeshProUGUI chatlogtext21;
    public TextMeshProUGUI chatlogtext22;
    public TextMeshProUGUI chatlogtext23;
    public TextMeshProUGUI chatlogtext24;
    public TextMeshProUGUI chatlogtext25;
    public TextMeshProUGUI chatlogtext26;
    public TextMeshProUGUI chatlogtext27;
    public TextMeshProUGUI chatlogtext28;
    public TextMeshProUGUI chatlogtext29;
    public TextMeshProUGUI chatlogtext30;
    public TextMeshProUGUI chatlogtext31;
    public TextMeshProUGUI chatlogtext32;
    public TextMeshProUGUI chatlogtext33;
    public TextMeshProUGUI chatlogtext34;
    public TextMeshProUGUI chatlogtext35;
    public TextMeshProUGUI chatlogtext36;
    public TextMeshProUGUI chatlogtext37;
    public TextMeshProUGUI chatlogtext38;

    public List<TextMeshProUGUI> chatLogHolder;

    // Start is called before the first frame update
    void Start()
    {
        linesclickedrun();
        //chatLogHolder.Add();
    }

    // Update is called once per frame
    void Update()
    {
        linesclickedrun();

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
            chatlogtext1.text = "…";
        }

        if (textboxscript.line2Ran == true)
        {
            chatlogtext2.text = "Hm today should be a light day work wise, let me look at my schedule.";
        }
        if (textboxscript.line3Ran == true)
        {
            chatlogtext3.text = "one patient until lunch time, cool let me see their records.";
        }
        if (textboxscript.line4Ran == true)
        {
            chatlogtext4.text = "The patient is a 27 year old, it says they were coming to therapy due to depression.";
        }
        if (textboxscript.line5Ran == true)
        {
            chatlogtext5.text = "? The patient was banned from their last therapy office after an incident with staff? I wonder what happened?";
        }
        if (textboxscript.line6Ran == true)
        {
            chatlogtext6.text = "Why do these records feel a bit… lacking? It’s missing way too much information! How’d the patient get depression? And what was the incident that happened with the staff??";
        }
        if (textboxscript.line7Ran == true)
        {
            chatlogtext7.text = "Oh well i guess i'll just have to find out about the patient myself, worse case scenario I have my emergency button under my desk";
        }
        if (textboxscript.line8Ran == true)
        {
            chatlogtext8.text = "Picks up phone";
        }
        if (textboxscript.line9Ran == true)
        {
            chatlogtext9.text = "Hello nurse joey can you send the patient to my office now? I’m ready,thank you. ";
        }
        if (textboxscript.line10Ran == true)
        {
            chatlogtext10.text = "Knock Knock";
        }
        if (textboxscript.line11Ran == true)
        {
            chatlogtext11.text = "Hello! You can enter.";
        }
        if (textboxscript.line11Ran == true)
        {
            chatlogtext11.text = "Hello, I’ll be your therapist. Nice to meet you.";
        }
        if (textboxscript.line12Ran == true)
        {
            chatlogtext12.text = "Hello! I’m Lyco. It's nice to meet you too!";
        }
        if (textboxscript.line13Ran == true)
        {
            chatlogtext13.text = "This patient seems pretty nice!";
        }
        if (textboxscript.line14Ran == true)
        {
            chatlogtext14.text = "So, tell me a little about yourself, what do you do for a living?";
        }
        if (textboxscript.line15Ran == true)
        {
            chatlogtext15.text = "I work in IT, what about you did you have any past jobs?";
        }
        if (textboxscript.line16Ran == true)
        {
            chatlogtext16.text = "Huh!? Oh, no not really.";
        }
        if (textboxscript.line17Ran == true)
        {
            chatlogtext17.text = "I see.";
        }
        if (textboxscript.line18Ran == true)
        {
            chatlogtext18.text = "when you're not working what do you like to do for fun?";
        }
        if (textboxscript.line19Ran == true)
        {
            chatlogtext19.text = "Me? I like, watching badman";
        }
        if (textboxscript.line20Ran == true)
        {
            chatlogtext20.text = "Nice me too!";
        }
        if (textboxscript.line21Ran == true)
        {
            chatlogtext21.text = "It says here on your records that you suffer from depression, would you like to talk about it?";
        }
        if (textboxscript.line22Ran == true)
        {
            chatlogtext22.text = "Yes…";
        }
        if (textboxscript.line23Ran == true)
        {
            chatlogtext23.text = "It all started when my first crush rejected me.";
        }
        if (textboxscript.line24Ran == true)
        {
            chatlogtext24.text = "Ever since then it feels as though there's been something missing from my life.";
        }
        if (textboxscript.line25Ran == true)
        {
            chatlogtext25.text = "They were my everything.";
        }
        if (textboxscript.line26Ran == true)
        {
            chatlogtext26.text = "I see, being let down can be hard, have you ever considered getting a hobby to ease your mind away from the situation?";
        }
        if (textboxscript.line27Ran == true)
        {
            chatlogtext27.text = "I did however that person introduced me to a new hobby that I enjoyed so now that they aren’t in my life I can no longer take joy in doing the hobby with someone else.";
        }
        if (textboxscript.line28Ran == true)
        {
            chatlogtext28.text = "I understand that memories of a person can make it difficult to do things that you used to do with them.";
        }
        if (textboxscript.line29Ran == true)
        {
            chatlogtext29.text = "How about finding someone else to do that hobby with.";
        }
        if (textboxscript.line30Ran == true)
        {
            chatlogtext30.text = "Yes, that way your memories of the past person are overridden, you don’t even have to find someone new to enjoy your hobby with, you can start with someone close to you.";
        }
        if (textboxscript.line31Ran == true)
        {
            chatlogtext31.text = "...";
        }
        if (textboxscript.line32Ran == true)
        {
            chatlogtext32.text = "This…does sound interesting.";
        }
        if (textboxscript.line33Ran == true)
        {
            chatlogtext33.text = "For example my hobby is listening to music which is why I work in a music therapy office.";
        }
        if (textboxscript.line34Ran == true)
        {
            chatlogtext34.text = "I enjoy sharing my hobby with others, would you like to listen to some music with me?";
        }
        if (textboxscript.line35Ran == true)
        {
            chatlogtext35.text = "Yes please!";
        }
        if (textboxscript.line36Ran == true)
        {
            chatlogtext36.text = "To the game!";
            SceneManager.LoadScene("Taylor test");
        }
        if (textboxscript.line37Ran == true)
        {
            chatlogtext37.text = "";
        }
        if (textboxscript.line38Ran == true)
        {
            chatlogtext38.text = "";
        }

    }
}
