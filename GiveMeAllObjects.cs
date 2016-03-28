using UnityEngine;
using System.Collections;

public class GiveMeAllObjects : MonoBehaviour 
{

    private GameObject[] allObject;

    void Awake ()
    {
        allObject = (GameObject[])GameObject.FindObjectsOfType<GameObject>();

        foreach(GameObject go in allObject)
        {
            Debug.Log(go.name);
        }

    }
       
}
