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

    public int linesran =0;

    

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
        }
        if (linesran >= 15)
        {
            line15Ran = true;
        }
        if (linesran >= 16)
        {
            line16Ran = true;
        }
        if (linesran >= 17)
        {
            line17Ran = true;
        }
        if (linesran >= 18)
        {
            line18Ran = true;
        }
        if (linesran >= 19)
        {
            line19Ran = true;
        }
        if (linesran >= 20)
        {
            line20Ran = true;
        }
        if (linesran >= 21)
        {
            line21Ran = true;
        }
        if (linesran >= 22)
        {
            line22Ran = true;
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
}
