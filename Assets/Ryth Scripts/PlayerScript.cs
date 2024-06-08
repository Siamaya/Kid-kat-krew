using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private SpriteRenderer thePl;
    public Sprite defaultImage;
    public Sprite pressedImage;

    // Start is called before the first frame update
    void Start()
    {
        thePl = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            thePl.sprite = defaultImage;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thePl.sprite = pressedImage;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
