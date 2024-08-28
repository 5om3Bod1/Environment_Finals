using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thiefDoor : MonoBehaviour
{
    public static bool readPick;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        if (readPick)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        readPick = thiefText.pick;
    }


}
