using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print("Trigger name: " + gameObject.name);
    }
}
