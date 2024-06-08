using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatController : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public static BeatController instance2;

    List<float> whichNote1 = new List<float> { };
    List<float> whichNote = new List<float> {12,1,1,0,1,4,12,1,1,0,4,1,1,10,1,1,2,3,6,7,2,3,1,4,5,4,1,1,2,5,4,7,11,7,7,7,7,7,
                                            7,7,7,7,7,4,3,4,3,5,4,3,5,7,12,2,1,1,5,6,7,2,4,5,1,0,2,7,7,7,7,7,7,7,7,7,20};
    public int noteMark = 0;
    public Transform noteObj1;
    public Transform noteObj2;
    public Transform noteObj3;
    public Transform noteObj4;
    public Transform noteObj5;
    public Transform noteObj6;
    public Vector3 offset1;
    public string timerReset = "y";
    public float xPos = 8;
    public float closeTogether;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
        hasStarted = false;
        closeTogether = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f, 0f); //keep this for now
            if (timerReset == "y")
            {
                StartCoroutine(SpawnNote(Random.Range(1, 4)));
                timerReset = "n";
            }
        }
    }
    IEnumerator SpawnNote(int randomNumber)
    {
        yield return new WaitForSeconds(closeTogether);

        if (whichNote[noteMark] == 1)
        {
            //'this' stands for the postition of the prefab. To change it's position change the value in the prefav itself
            Instantiate(noteObj1, this.transform, worldPositionStays: true);
        }
        if (whichNote[noteMark] == 2)
        {
            Instantiate(noteObj2, this.transform, worldPositionStays: true);
        }
        if (whichNote[noteMark] == 3)
        {
            Instantiate(noteObj3, this.transform, worldPositionStays: true);
        }
        if (whichNote[noteMark] == 4)
        {
            Instantiate(noteObj4, this.transform, worldPositionStays: true);
        }
        if (whichNote[noteMark] == 5)
        {
            Instantiate(noteObj5, this.transform, worldPositionStays: true);
        }
        if (whichNote[noteMark] == 6)
        {
            Instantiate(noteObj6, this.transform, worldPositionStays: true);
        }
        if (whichNote[noteMark] == 7)
        {
            
        }
        if (whichNote[noteMark] == 0)
        {
            //rest note
            closeTogether = 0.5f;
        }
        if (whichNote[noteMark] == 10)
        {
            beatTempo = ((beatTempo * 60f) * 2) / 60f;
        }
        if (whichNote[noteMark] == 11)
        {
            beatTempo = ((beatTempo * 60f) / 2) / 60f;
        }
        if (whichNote[noteMark] == 12)
        {
            closeTogether = 0.3f;
        }
        if (whichNote[noteMark] == 13)
        {
            closeTogether = 0.3f;
        }
        if (whichNote[noteMark] == 14)
        {
            beatTempo = ((beatTempo * 60f) * 3) / 60f;
        }
        if (whichNote[noteMark] == 15)
        {
            beatTempo = ((beatTempo * 60f) / 3) / 60f;
        }
        if (whichNote[noteMark] == 20)
        {
            hasStarted = false;
            RythMage.instance.evthElse.text = "Thanks for Playing the Demo!";
            RythMage.instance.theMusic.Stop();
        }

        noteMark += 1;
        timerReset = "y";
    }
}
