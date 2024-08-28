using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class witchText : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public bool convo;

    public static bool relic = false;

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
        if (!convo)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.red;
                welMessage.text = ("What brings you here traveler?");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("I heard you were up to something that might be of help to me.");
            }
            if (textCount == 3)
            {
                welMessage.color = Color.red;
                welMessage.text = ("What is it that you are looking for..");
            }
            if (textCount == 4)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("I'm helping someone find their great grandmother's treasures.");
            }
            if (textCount == 5)
            {
                welMessage.color = Color.red;
                welMessage.text = ("And how can I help with that?");
            }
            if (textCount == 5)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("Do you know any spells or relics that can be of any assistance?");
            }
            if (textCount == 5)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("I'm thinking to go into the past.");
            }
            if (textCount == 6)
            {
                welMessage.color = Color.red;
                welMessage.text = ("The past you say.. Well I've been working on something. I'm not sure if it works.");
            }
            if (textCount == 7)
            {
                welMessage.color = Color.red;
                welMessage.text = ("A relic when shaken transports you back hundreds of years back.");
            }
            if (textCount == 8)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("What does it cost? I'll buy it.");
            }
            if (textCount == 9)
            {
                welMessage.color = Color.red;
                welMessage.text = ("There is no value on it currently, since I'm not sure if it works.");
            }
            if (textCount == 10)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Let's say it might costs you life..");
            }
            if (textCount == 11)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("I'm fine with trying it.");
            }
            if (textCount == 12)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Don't say I didn't warn you.");
            }
            if (textCount == 13)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("*Click 'E' for the past and 'Q' for the present.*");
            }
            if (textCount == 14)
            {
                welMessage.text = ("");
                convo = true;
                textCount = 0;

                relic = true;
            }
        }
        if (convo)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Let me know how it goes!");
            }
            if (textCount == 2)
            {
                welMessage.text = ("");
            }
        }
    }
}
