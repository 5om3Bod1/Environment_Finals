using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class girlText : MonoBehaviour
{

    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public GameObject girl1;
    public GameObject helper;

    void Start()
    {
        girl1.SetActive(false);
        helper.SetActive(false);

        //Blank on start
        welMessage.text = ("");
    }

    private void OnMouseDown()
    {
        textCount++;
    }

    private void Update()
    {
        if (textCount == 1)
        {
            welMessage.color = Color.red;
            welMessage.text = ("Hi you don't seem like you're from around here?");
        }
        if (textCount == 2)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("Just passing through, although I heard rumors this town is built upon an old one?");
        }
        if (textCount == 3)
        {
            welMessage.color = Color.red;
            welMessage.text = ("You're just passing by? I see, and I'm not sure of the rumors you've heard.");
        }
        if (textCount == 4)
        {
            welMessage.color = Color.red;
            welMessage.text = ("You mind helping me with something?");
        }
        if (textCount == 5)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("Whats your request?");
        }
        if (textCount == 6)
        {
            welMessage.color = Color.red;
            welMessage.text = ("My Mom told me my great grandmother left her treasure some where in this town.");
        }
        if (textCount == 7)
        {
            welMessage.color = Color.red;
            welMessage.text = ("I've been looking for it nearly all my life and haven't found a trace.");
        }
        if (textCount == 8)
        {
            welMessage.color = Color.red;
            welMessage.text = ("You think we can find it? I'll pay you handedly for it.");
        }
        if (textCount == 9)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("You have a deal.");
        }
        if (textCount == 10)
        {
            welMessage.color = Color.red;
            welMessage.text = ("Thank you so much, the names Estefania P.");
        }
        if (textCount == 11)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("Nice to meet you, names ...");
        }
        if (textCount == 12)
        {
            welMessage.text = ("");
            textCount = 0;
            girl1.SetActive(true);
            helper.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
