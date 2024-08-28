using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class thiefText : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public bool sneak;
    public bool sold;
    public bool thank;
    public int sceneNum;

    public static bool pick = false;
    public static bool readRing;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        textCount++;
    }

    // Update is called once per frame
    void Update()
    {
        readRing = graveDig.ring;

        if (!sneak && !readRing)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Oh you caught me by surprise!");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Don't you know now to sneak up on people.");
            }
            if (textCount == 3)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("I'm sorry, didn't mean that.");
            }
            if (textCount == 4)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("What are you even doing sneaking around here?");
            }
            if (textCount == 5)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Look if you stay quiet I'll give you this key.");
            }
            if (textCount == 6)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("You have a deal.");
            }
            if (textCount == 7)
            {
                welMessage.text = ("");
                sneak = true;
                textCount = 0;
                pick = true;
            }

        }
        if (sneak && !readRing)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("What's it used for?");
            }

            if (textCount == 2)
            {
                welMessage.color = Color.red;
                welMessage.text = ("That's for you to find out.");
            }
            if (textCount == 3)
            {
                welMessage.text = ("");
                textCount = 0;
            }
        }

        if (readRing)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.red;
                welMessage.text = ("What you got over there");
            }

            if (textCount == 2)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("A ring I'm returning to someone.");
            }
            if (textCount == 3)
            {
                welMessage.color = Color.red;
                welMessage.text = ("You know, I can buy it off of you for 250 gold coins.");
            }
            if (textCount == 4)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("*Click 'Y' for yes and 'N' for no*");
            }

            //Sold
            if (Input.GetKeyUp("y") && textCount >= 4)
            {
                welMessage.text = ("Thank you for your buisness. Here is you're gold.");
                sold = true;
            }
            if (textCount >= 5 && sold)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("*+250 Gold Coins*");
                thank = true;
            }
            if (textCount >= 6 && thank)
            {
                SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
            }

            //!Sold
            if (Input.GetKeyUp("n") && textCount >= 4)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("No thanks, I must go now.");
                sold = false;
            }
            if (textCount >= 5 && !sold)
            {
                welMessage.text = ("");
            }
        }
    }
}
