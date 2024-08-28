using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wireDoor : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;

    public static bool readCut;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        if (readCut)
        {
            gameObject.SetActive(false);
        }
        if (!readCut)
        {
            textCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        readCut = wireCutter.cut;

        if (textCount == 1)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("I need a wirecutter for this.");
        }
        if (textCount == 2)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("Where the hell can I find that?");
        }
        if (textCount == 3)
        {
            welMessage.text = ("");
            textCount = 0;
        }

    }


}
