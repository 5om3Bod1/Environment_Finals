using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class correctGrave : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public bool done;

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
        if (!done)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("Ashely P.");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("Is this the grave of Estefania's great grandmother?");
            }
            if (textCount == 3)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("It must be the last names match.");
                textCount = 0;
                done = true;
            }
        }

        if (done)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("What now.");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("It has to be somewhere around here..");
            }
            if (textCount == 3)
            {
                welMessage.text = ("");
                textCount = 0;
            }
        }
    }
}
