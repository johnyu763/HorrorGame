using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door")
        {
            // Debug.Log("Entered.");
            Animator anim = other.GetComponentInChildren<Animator>();

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Pressed E.");
                anim.SetTrigger("DoorButton");
            }
        }
    }
}
