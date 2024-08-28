using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relicWarp : MonoBehaviour
{
    public static bool readRelic;
    public GameObject present;
    public GameObject past;
    public bool origin;

    // Start is called before the first frame update
    void Start()
    {
        past.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        readRelic = witchText.relic;

        if (readRelic)
        {
            if (Input.GetKeyUp("e") && origin == false)
            {
                Debug.Log(readRelic);
                Debug.Log(origin);
                past.SetActive(true);
                present.SetActive(false);
                origin = true;
            }
            if (Input.GetKeyUp("q") && origin == true)
            {
                past.SetActive(false);
                present.SetActive(true);
                origin = false;
            }
        }
        
    }
}
