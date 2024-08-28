using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class helperText : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public bool witch;

    public static bool key = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnMouseDown()
    {
        textCount++;
    }

    void Update()
    {
        if (!witch)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Hi you mind helping me real quick.");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.red;
                welMessage.text = ("I'm the Witch's assistance and I'm running late!");
            }
            if (textCount == 3)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Can you let her know I'll be running late. Thank you so much!");
            }
            if (textCount == 4)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Here! The keys to the shop.");
            }
            if (textCount == 5)
            {
                welMessage.text = ("");
                witch = true;
                textCount = 0;
                key = true;
            }

        }

        if (witch)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.red;
                welMessage.text = ("She should down the block from here.");
            }

            if (textCount == 2)
            {
                welMessage.color = Color.red;
                welMessage.text = ("The building with a platform connected to it at the roof.");
            }
            if (textCount == 3)
            {
                welMessage.text = ("");
                textCount = 0;
            }
        }
    }   
}
