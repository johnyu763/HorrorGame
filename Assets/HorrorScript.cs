using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorScript : MonoBehaviour
{
    public Material mat;
 

    void Start()
    {

        RenderSettings.skybox = mat;

    }
}
