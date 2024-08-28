using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class punk : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public GameObject kid;

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
            if (textCount == 1)
            {
            welMessage.color = Color.red;
            welMessage.text = ("What you looking at?!");
            }
            if (textCount == 2)
            {
                welMessage.text = ("");
            }
            if (textCount == 3)
            {
            welMessage.color = Color.red;
            welMessage.text = ("You looking for trouble or some?");
            }
            if (textCount == 4)
            {
                welMessage.text = ("");
            }
            if (textCount == 5)
            {
            welMessage.color = Color.red;
            welMessage.text = ("Go bother someone else!?");
            }
            if (textCount == 6)
            {
                welMessage.text = ("");
            }
            if (textCount == 7)
            {
            welMessage.color = Color.red;
            welMessage.text = ("Can you stop looking at me?! I'm insecure?!");
            }
            if (textCount == 8)
            {
                welMessage.text = ("");
            }
            if (textCount == 9)
            {
            welMessage.color = Color.red;
            welMessage.text = ("That's it I'm out!");
            }
            if (textCount == 10)
            {
                welMessage.text = ("");
                kid.SetActive(false);
            }
    }
}

