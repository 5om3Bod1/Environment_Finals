using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopDoor : MonoBehaviour
{
    public static bool readDoor;
    public static bool readCut;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        if (readDoor || readCut)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        readDoor = shopKeeper.door;
        readCut = wireCutter.cut;
    }


}

