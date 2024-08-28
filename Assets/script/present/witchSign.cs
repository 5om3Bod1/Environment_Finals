using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class witchSign : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;

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
            welMessage.color = Color.blue;
            welMessage.text = ("Witch' Shop..");
        }
        if (textCount == 2)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("Where magic and curses happen..");
        }
        if (textCount == 3)
        {
            welMessage.text = ("");
            textCount = 0;
        }
    }
}
