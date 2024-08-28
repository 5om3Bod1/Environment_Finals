using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class graveDig : MonoBehaviour
{
    public TMP_Text welMessage;
    public GameObject textMessage;
    public int textCount;

    public GameObject dirt;
    public GameObject treasure;

    public static bool readDig;

    public static bool ring = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        if (readDig)
        {
            textCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        readDig = shovelRoof.dig;

        if (textCount == 1)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("This feels so wrong to do.");
        }
        if (textCount == 2)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("I'm so sorry Ashely P.");
        }
        if (textCount == 3)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("There I did it..");
            dirt.SetActive(false);
        }
        if (textCount == 4)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("Theres the treasure.");
            ring = true;
            treasure.SetActive(false);
        }
        if (textCount == 5)
        {
            welMessage.color = Color.blue;
            welMessage.text = ("I guess I'm done here");
        }
        if (textCount == 6)
        {
            welMessage.text = ("");
        }

    }


}