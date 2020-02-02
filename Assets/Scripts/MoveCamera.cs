//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Moving Player;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {

        //var rot = Input.GetAxisRaw("Mouse X") * Time.deltaTime * 180;
        var vert = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 180;
        //offset = Quaternion.AngleAxis(rot, Vector3.up) * offset;
        //transform.position = Player.transform.position + offset;

        Debug.Log(transform.rotation.x);
        //Debug.Log(vert);
        if(vert >= 30f || vert <= -30f)
        {

        }
        else if(-0.4f <= transform.rotation.x && transform.rotation.x <= 0.4f) 
        {
            transform.Rotate(-vert, 0f,0f);
        }
        else if(-0.39f >= transform.rotation.x && vert <= 0)
        {
            transform.Rotate(-vert, 0f, 0f);
        }
        else if (0.39f <= transform.rotation.x && vert >= 0)
        {
            transform.Rotate(-vert, 0f, 0f);
        }

    }
}
