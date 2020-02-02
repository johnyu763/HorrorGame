using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionControl : MonoBehaviour
{
    private Animator anim;
    private int stateNum = 0;
    public GameObject horror;
    public GameObject home;
    public GameObject bathDoor;
    private bool played = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            StartCoroutine(nextState());
        }

        if(stateNum >= 2 && !played)
        {
            Animator altnim = bathDoor.GetComponent<Animator>();
            StartCoroutine(teleport());
            altnim.SetTrigger("DoorButton");

        }
    }

    public IEnumerator nextState()
    {
        anim.SetInteger("stateNum", ++stateNum);
        yield return new WaitForSeconds(10f);
    }
    
    IEnumerator teleport()
    {
        yield return new WaitForSeconds(5f);
        home.SetActive(false);
        horror.SetActive(true);
        played = true;
    }
}
