using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    private Color startColor;
    private Color highlightColor = Color.yellow;

    private Renderer ren;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        startColor = ren.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        ren.material.SetColor("_Color", highlightColor);
    }
    void OnMouseExit()
    {
        ren.material.SetColor("_Color", startColor);
    }
}
