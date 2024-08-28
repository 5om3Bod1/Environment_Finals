using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witchDoor : MonoBehaviour
{

    public static bool readKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        if (readKey)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        readKey = helperText.key;
    }

}
