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
                // Debug.Log("Pressed E.");
                anim.SetTrigger("DoorButton");
            }
        }
        else if (other.tag == "PillBottle")
        {
            Debug.Log("Entered");
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject questLog = GameObject.FindGameObjectWithTag("Quests");

                if (questLog != null)
                {
                    StartCoroutine(questLog.GetComponent<MissionControl>().nextState());
                                        
                    GameObject.FindGameObjectWithTag("PillBottle").transform.GetChild(0).GetComponent<Highlight>().isHighlightable = false;
                    other.tag = "Disable";
                }
            }
        }
    }
}
