using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHome : MonoBehaviour
{
    public GameObject home;
    public GameObject horror;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Homeward());
    }

    IEnumerator Homeward()
    {
        yield return new WaitForSeconds(3f);
        home.SetActive(true);
        RenderSettings.skybox = mat;
        horror.SetActive(false);
        
    }
}
