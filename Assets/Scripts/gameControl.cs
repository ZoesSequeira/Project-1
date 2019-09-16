using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{
    int printTest = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > 2.99 && printTest == 0)
        {
            print("It's been three seconds!");
            printTest = 1;
        }

    }
}
