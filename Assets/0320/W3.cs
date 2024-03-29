using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("hello");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            print("mouse 0");
        }
    }
}
