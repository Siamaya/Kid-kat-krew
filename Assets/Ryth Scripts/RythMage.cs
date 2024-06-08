using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RythMage : MonoBehaviour
{
    public static RythMage instance;

    public AudioSource theMusic;
    public bool startPlaying;
    public BeatController theBS;

    public int currentScore;
    public int scorePerNote;
    public int scoreForGN;
    public int scoreForPN;
    public int okayNote;
    public int goodNote;
    public int perfectNote;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public TMP_Text scoreText;
    public TMP_Text multiText;
    public TMP_Text okayText;
    public TMP_Text goodText;
    public TMP_Text perfectText;
    public TMP_Text evthElse;

    public Slider healthBar;
    public float healthNum;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scorePerNote = 100;
        scoreForGN = 125;
        scoreForPN = 150;
        okayNote = 1;
        goodNote = 1;
        perfectNote = 1;
        currentMultiplier = 1;
        healthNum = 5f;
        gameOver = false;
        Time.timeScale = 1;
        evthElse.text = "Press Anykey to Start";
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                evthElse.text = "";
                startPlaying = true;
                theBS.hasStarted = true;
                theMusic.Play();
            }
        }
        healthBar.value = healthNum;
        scoreText.text = "Score: " + currentScore;
        if (healthNum <= 0)
        {
            gameOver = true;
            evthElse.text = "Game Over" + "\nTry Again?" + "\n\nPress 'R' to restart";
        }
        if (gameOver)
        {
            Time.timeScale = 0;
        }
    }
    public void NoteHit()
    {
        multiplierTracker++;
        if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
        {
            multiplierTracker = 0;
            currentMultiplier++;
        }
        multiText.text = "Multiplier: x" + currentMultiplier;
        scoreText.text = "Score " + currentScore;
    }

    public void NormalNote()
    {
        currentScore += scorePerNote * currentMultiplier;
        okayText.text = "Okay: " + okayNote;
        if (healthBar.value < 5)
        {
            healthNum += 0.1f;
        }
        NoteHit();
    }
    public void GoodNote()
    {
        currentScore += scoreForGN * currentMultiplier;
        goodText.text = "Good: " + goodNote;
        if (healthBar.value < 5)
        {
            healthNum += 0.3f;
        }
        NoteHit();
    }
    public void PerfectNote()
    {
        currentScore += scoreForPN * currentMultiplier;
        perfectText.text = "Perfect: " + perfectNote;
        if (healthBar.value < 5)
        {
            healthNum += 0.5f;
        }
        NoteHit();
    }
    public void NoteMissed()
    {
        Debug.Log("Note Missed");
        currentMultiplier = 1;
        multiplierTracker = 0;
        currentScore -= 200;
        healthNum -= 1;
        multiText.text = "Multiplier: x" + currentMultiplier;
    }
    public void EarlyNote()
    {
        currentScore -= 100;
        healthNum -= 1;
    }
}
