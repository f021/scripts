using UnityEngine;
using System.Collections;

public class RandomColorMaterial : MonoBehaviour 
{

    void Update()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
       
}
