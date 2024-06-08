using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFunctions : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public KeyCode extraNote;
    public bool normalNote;
    public bool hasBeenPressed;
    // Start is called before the first frame update
    void Start()
    {
        normalNote = true;
        hasBeenPressed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (normalNote == true)
        {
            if (Input.GetKeyDown(keyToPress))
            {
                if (canBePressed == true)
                {
                    gameObject.SetActive(false);
                    hasBeenPressed = true;

                    if (Mathf.Abs(transform.position.x) > 8.25)
                    {
                        Debug.Log("Okay...");
                        RythMage.instance.NormalNote();
                        RythMage.instance.okayNote += 1;
                    }
                    else if (Mathf.Abs(transform.position.x) > 8.05)
                    {
                        Debug.Log("Good");
                        RythMage.instance.GoodNote();
                        RythMage.instance.goodNote += 1;
                    }
                    else
                    {
                        Debug.Log("Perfect!");
                        RythMage.instance.PerfectNote();
                        RythMage.instance.perfectNote += 1;
                    }
                }
            }
        }
        else if (!normalNote)
        {
            if (gameObject.tag == "2B")
            {
                if (Input.anyKeyDown)
                {
                    gameObject.SetActive(false);
                    hasBeenPressed = true;
                    RythMage.instance.NoteMissed();
                }
            }
            else if (gameObject.tag == "3B")
            {
                if (Input.GetKeyDown(keyToPress) & Input.GetKey(extraNote))
                {
                    gameObject.SetActive(false);
                    hasBeenPressed = true;

                    if (Mathf.Abs(transform.position.x) > 8.25)
                    {
                        Debug.Log("Okay...");
                        RythMage.instance.NormalNote();
                        RythMage.instance.okayNote += 1;
                    }
                    else if (Mathf.Abs(transform.position.x) > 8.05)
                    {
                        Debug.Log("Good");
                        RythMage.instance.GoodNote();
                        RythMage.instance.goodNote += 1;
                    }
                    else
                    {
                        Debug.Log("Perfect!");
                        RythMage.instance.PerfectNote();
                        RythMage.instance.perfectNote += 1;
                    }
                }
            }
        }

        if (hasBeenPressed == false)
        {
            if (gameObject.tag == "2B")
            {

            }
            else
            {
                RythMage.instance.NoteMissed();
            }
            hasBeenPressed = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            /*if (!canBePressed)
            {
                gameManagerScript.instance.EarlyNote();
                gameManagerScript.instance.NoteMissed();
                hasBeenPressed = true;
                canBePressed = true;
                /*This wouldn't work due to it's checking every single note that can't be pressed (!canBePressed). 
                 * Setting canBePressed = true later would make all notes on screen (that only requires the space bar to be pressed) 
                 * will be set to Active(false). Not only that but it's sensitive(?) as even though the note can be pressed, it will see 
                 * all the notes that were instantiated behind the note that is next to the player, were all set to !canBePressed. 
                 * The code seems to think they are all together; however in Unity, the notes function on itself. Also removing 
                 * canBePressed = true, causes the code to activate constaintly. I don't know why but maybe its connected to each frame? 
                 * Okay future me you got this! (I hope)
            }*/
        }
        //PLEASE LOOK AT THIS, FUTURE ME!
        //no
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            Destroy(gameObject);
            Debug.Log("Collided");
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
        if (gameObject.tag == "2B")
        {
            normalNote = false;
        }
        if (gameObject.tag == "3B")
        {
            normalNote = false;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            hasBeenPressed = false;
        }
        if (gameObject.tag == "2B")
        {
            normalNote = true;
        }
        if (gameObject.tag == "3B")
        {
            normalNote = true;
        }
    }
}
