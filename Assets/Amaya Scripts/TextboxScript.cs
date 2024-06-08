using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextboxScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;

    
    public TextMeshProUGUI chatLog;
    public GameObject ChatLogScript;

    public GameObject nametextbox;
    public TextMeshProUGUI nametextboxtext;

    public int linesran =0;

    public GameObject PaitentBlankStare;
    public GameObject PaitentBlankStareTalk;
    public GameObject PaitentMad;
    public GameObject PaitentMadTalking;
    public GameObject PaitentSadTalking;
    public GameObject PaitentSad;
    public GameObject PaitentHappy;
    public GameObject PaitentHappyTalking;



    public bool line1Ran = true;
    public bool line2Ran = false;
    public bool line3Ran = false;
    public bool line4Ran = false;
    public bool line5Ran = false;
    public bool line6Ran = false;
    public bool line7Ran = false;
    public bool line8Ran = false;
    public bool line9Ran = false;
    public bool line10Ran = false;
    public bool line11Ran = false;
    public bool line12Ran = false;
    public bool line13Ran = false;
    public bool line14Ran = false;
    public bool line15Ran = false;
    public bool line16Ran = false;
    public bool line17Ran = false;
    public bool line18Ran = false;
    public bool line19Ran = false;
    public bool line20Ran = false;
    public bool line21Ran = false;
    public bool line22Ran = false;
    public bool line23Ran = false;
    public bool line24Ran = false;
    public bool line25Ran = false;
    public bool line26Ran = false;
    public bool line27Ran = false;
    public bool line28Ran = false;
    public bool line29Ran = false;
    public bool line30Ran = false;
    public bool line31Ran = false;
    public bool line32Ran = false;
    public bool line33Ran = false;
    public bool line34Ran = false;
    public bool line35Ran = false;
    public bool line36Ran = false;
    public bool line37Ran = false;
    public bool line38Ran = false;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialouge();
        line1Ran = true;        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0)))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

        
    }
    void StartDialouge()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {

       
        linesran += 1;
        foreach (char c in lines[index].ToCharArray())
        {
            
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
            
        }

        if (linesran >= 1)
        {           
            line1Ran = true;
            Drnamebox();
        }
        if (linesran >= 2)
        {
            line2Ran = true;
        }
        if (linesran >= 3)
        {
            line3Ran = true;
        }
        if (linesran >= 4)
        {
            line4Ran = true;
        }
        if (linesran >= 5)
        {
            line5Ran = true;
        }
        if (linesran >= 6)
        {
            line6Ran = true;
        }
        if (linesran >= 7)
        {
            line7Ran = true;
        }
        if (linesran >= 8)
        {
            line8Ran = true;
        }
        if (linesran >= 9)
        {
            line9Ran = true;
        }
        if (linesran >= 10)
        {
            line10Ran = true;
        }
        if (linesran >= 11)
        {
            line11Ran = true;
        }
        if (linesran >= 12)
        {
            line12Ran = true;
        }
        if (linesran >= 13)
        {
            line13Ran = true;
            
        }
        if (linesran >= 14)
        {
            line14Ran = true;
            Paitentnamebox();
        }
        if (linesran >= 15)
        {
            line15Ran = true;
            Drnamebox();
        }
        if (linesran >= 16)
        {
            line16Ran = true;
            Drnamebox();

        }
        if (linesran >= 17)
        {
            line17Ran = true;
            Paitentnamebox();

        }
        if (linesran >= 18)
        {
            line18Ran = true;
            Drnamebox();

        }
        if (linesran >= 19)
        {
            line19Ran = true;
            Paitentnamebox();

        }
        if (linesran >= 20)
        {
            line20Ran = true;
            Drnamebox();

        }
        if (linesran >= 21)
        {
            line21Ran = true;
            Paitentnamebox();
        }
        if (linesran >= 22)
        {
            line22Ran = true;
            Drnamebox();
        }
        if (linesran >= 23)
        {
            line23Ran = true;
        }
        if (linesran >= 24)
        {
            line24Ran = true;
        }
        if (linesran >= 25)
        {
            line25Ran = true;
        }
        if (linesran >= 26)
        {
            line26Ran = true;
        }
        if (linesran >= 27)
        {
            line27Ran = true;
        }
        if (linesran >= 28)
        {
            line28Ran = true;
        }
        if (linesran >= 29)
        {
            line29Ran = true;
        }
        if (linesran >= 30)
        {
            line30Ran = true;
        }
        if (linesran >= 31)
        {
            line31Ran = true;
        }
        if (linesran >= 32)
        {
            line32Ran = true;
        }
        if (linesran >= 33)
        {
            line33Ran = true;
        }
        if (linesran >= 34)
        {
            line34Ran = true;
        }
        if (linesran >= 35)
        {
            line35Ran = true;
        }
        if (linesran >= 36)
        {
            line36Ran = true;
        }
        if (linesran >= 37)
        {
            line37Ran = true;
        }
        if (linesran >= 38)
        {
            line38Ran = true;
        }



    }
    public void NextLine()
    {
        if(index <lines.Length - 1)
        {
            
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            nametextbox.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    public void Drnamebox()
    {
        nametextboxtext.text = "Dr";
    }

    public void Paitentnamebox()
    {
        nametextboxtext.text = "Paitent";
    }
}
