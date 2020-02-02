using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject home;
    public GameObject dark;

    public GameObject firstDialogue;
    public GameObject endDialogue;

    private MissionControl mc;
    // Start is called before the first frame update
    private void Start()
    {
        mc = GameObject.FindGameObjectWithTag("Quests").GetComponent<MissionControl>();
    }
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
            // Debug.Log("Entered");
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject questLog = GameObject.FindGameObjectWithTag("Quests");

                if (questLog != null)
                {
                    StartCoroutine(questLog.GetComponent<MissionControl>().nextState());
                                        
                    GameObject.FindGameObjectWithTag("PillBottle").transform.GetChild(0).GetComponent<Highlight>().isHighlightable = false;
                    other.tag = "Disable";

                    StartCoroutine(showText());
                }
            }
        }
        else if (other.tag == "BathroomCabinet" && mc.stateNum == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Animator anim = other.GetComponentInChildren<Animator>();
                GameObject questLog = GameObject.FindGameObjectWithTag("Quests");

                if (questLog != null)
                {
                    anim.SetTrigger("DoorButton");

                    StartCoroutine(questLog.GetComponent<MissionControl>().nextState());

                    other.tag = "Door";
                }
            }
        }
        else if (other.tag == "CoffeeCup" && mc.stateNum == 2)
        {
            dark.SetActive(true);
            home.SetActive(false);

            StartCoroutine(showEnd());
        }
    }

    IEnumerator showText()
    {
        firstDialogue.SetActive(true);
        yield return new WaitForSeconds(5f);
        firstDialogue.SetActive(false);
    }

    IEnumerator showEnd()
    {
        yield return new WaitForSeconds(5f);
        endDialogue.SetActive(true);
    }
}
