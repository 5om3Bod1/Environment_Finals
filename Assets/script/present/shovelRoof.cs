using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shovelRoof : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;
    public GameObject shovel;
    public bool grab;

    public static bool dig = false;

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
        if (!grab)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("Shovels layed on the roof kind of strange.");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("I'll hold on to one. Might be of use.");
            }
            if (textCount == 3)
            {
                welMessage.text = ("");
                textCount = 0;
                dig = true;
                grab = true;
                shovel.SetActive(false);
            }
        }
        if (grab)
        {
            if (textCount == 1)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("Ones enough.");
            }
            if (textCount == 2)
            {
                welMessage.color = Color.blue;
                welMessage.text = ("");
            }
        }
    }
}
