using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class PositionCos : MonoBehaviour 
{
    protected int MAX = 50;
    private List<int> scenes = new List<int>();
    void Start()
    {
        scenes = new List<int>(Enumerable.Range(1,MAX));
        foreach (int a in scenes)
        {
            Debug.Log(a);
        }
    }
}
