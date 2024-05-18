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

        if(linesran >= 1)
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
