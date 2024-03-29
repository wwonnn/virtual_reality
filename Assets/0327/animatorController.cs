using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    public Animator animator;

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
        if(other.gameObject.name == "Robot_Transform")
        {
            animator.SetInteger("control", 1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Robot_Transform")
        {
            animator.SetInteger("control", 2);
        }
    }
}
