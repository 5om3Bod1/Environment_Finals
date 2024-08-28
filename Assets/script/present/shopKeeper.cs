using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shopKeeper : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public bool shop;

    public static bool door = false;

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
        if (!shop)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("Excuse me sir.");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Who's.. there.. my assistant?");
            }
            if (textCount == 3)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Can you help me open the downstairs shop up.");
            }
            if (textCount == 4)
            {
                welMessage.color = Color.red;
                welMessage.text = ("Here's the keys.");
                shop = true;
                textCount = 0;
                door = true;
            }
        }

        if (shop)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.red;
                welMessage.text = ("*snoring*");
            }

            if (textCount == 2)
            {
                welMessage.text = ("");
                textCount = 0;
            }
        }
    }
}
