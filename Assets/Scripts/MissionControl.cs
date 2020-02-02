﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionControl : MonoBehaviour
{
    private Animator anim;
    private int stateNum = 0;
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
    }

    public IEnumerator nextState()
    {
        anim.SetInteger("stateNum", ++stateNum);
        yield return new WaitForSeconds(10f);
    }
}
