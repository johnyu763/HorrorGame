//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Moving Player;
    public Vector3 offset;

    void Start()
    {
        //offset = transform.position - Player.transform.position;
    }

    void Update()
    {
        Debug.Log(Screen.currentResolution);
        var vert = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 180;
        Debug.Log(transform.rotation.x - vert / 180f);
        if(transform.rotation.x - vert/180f >= -0.3f && transform.rotation.x - vert/180f <= 0.35f)
        {
            transform.Rotate(-vert, 0f, 0f);
        }
      

    }
}
