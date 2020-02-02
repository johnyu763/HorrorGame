//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Moving Player;
    public Vector3 offset;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Debug.Log(Screen.currentResolution);
        var vert = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 180;
        Debug.Log(transform.rotation.x - vert / 180f);
        if(transform.rotation.x - vert/180f >= -0.4f && transform.rotation.x - vert/180f <= 0.5f)
        {
            transform.Rotate(-vert, 0f, 0f);
        }

    }
}
