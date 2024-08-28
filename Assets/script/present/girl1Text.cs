using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class girl1Text : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public bool hint;
    public int sceneNum;

    public static bool readRing;

    void Start()
    {
        //Sets a timer for a hint
        Invoke("help", 60f);
    }

    private void OnMouseDown()
    {
        textCount++;
    }

    void Update()
    {
        readRing = graveDig.ring;

        if (textCount == 1)
        {
            welMessage.text = ("Did you find it yet?");
        }

        //When its not found
        if (!readRing)
        {
            //No help
            if (textCount == 2)
            {
                welMessage.text = ("Not yet.");
            }
            if (textCount == 3 && hint == false)
            {
                welMessage.text = ("Comeback in a bit, I'll also continue my search.");
            }
            if (textCount == 4 && hint == false)
            {
                textCount = 0;
                welMessage.text = ("");
            }

            //Yes help
            if (textCount == 3 && hint == true)
            {
                welMessage.text = ("I did hear people talking about the town's witch being up to somethng.");
            }
            if (textCount == 4 && hint == true)
            {
                welMessage.text = ("Maybe seek her for help?");
            }
            if (textCount == 5 && hint == true)
            {
                textCount = 0;
                welMessage.text = ("");
            }
        }

        //When its found
        if (readRing)
        {
            if (textCount == 2)
            {
                welMessage.text = ("Is this what you were looking for?");
            }
            if (textCount == 3)
            {
                welMessage.text = ("Oh my god, YES! Thank you so much.");
            }
            if (textCount == 4)
            {
                welMessage.text = ("No problem, glad I can help.");
            }
            if (textCount == 5)
            {
                welMessage.text = ("Here is your payment. Thank you again.");
            }
            if (textCount == 6)
            {
                welMessage.text = ("*+500 Gold Coins*");
            }
            if (textCount == 7)
            {
                SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
            }
        }
    }

    void help()
    {
        hint = true;
    }
}
