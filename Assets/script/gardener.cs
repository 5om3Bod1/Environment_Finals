using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gardener : MonoBehaviour
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
            welMessage.text = ("My grandpa is a gardener.");
            }
            if (textCount == 2)
            {
            welMessage.color = Color.red;
            welMessage.text = ("He likes to keep his supplies on a roof.");
            }
            if (textCount == 3)
            {
            welMessage.color = Color.blue;
            welMessage.text = ("Thats pretty cool kid.");
            }
            if (textCount == 4)
            {
            welMessage.color = Color.red;
            welMessage.text = ("Wait, why I'm I talking to strangers again.");
            }
            if (textCount == 5)
            {
            welMessage.color = Color.red;
            welMessage.text = ("Sorry I must go.");
            }
            if (textCount == 6)
            {
                welMessage.text = ("");
                kid.SetActive(false);
            }
    }
}
