using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wireCutter : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public GameObject cutter;

    public static bool cut = false;

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
        {
            if (textCount == 1)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("Why's there wire cutters on the bed?");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("I'll hold on to it. Might be of use.");
            }
            if (textCount == 3)
            {
                welMessage.text = ("");
                textCount = 0;
                cut = true;

                cutter.SetActive(false);
            }
        }
    }
}
