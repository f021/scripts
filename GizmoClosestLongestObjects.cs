using UnityEngine;
using System.Collections;

public class GizmoClosestLongestObjects : MonoBehaviour 
{

    public bool closest = true;
    public bool longest = true;

    private GameObject[] allObject;

    void OnDrawGizmosSelected () 
    {
        allObject = (GameObject[])GameObject.FindObjectsOfType<GameObject>();

        float maxDistance = 0f;
        float minDistance = Mathf.Infinity;

        Transform targetClosest = null;
        Transform targetLongest = null;

        foreach (GameObject go in allObject)
        {
            float distance = (transform.position - go.transform.position).magnitude;

            if (distance > maxDistance)
            {
                maxDistance = distance;
                targetLongest = go.transform;
            }

            if (distance < minDistance && name != go.name)
            {
                minDistance = distance;
                targetClosest = go.transform;
            }

        }

        if (closest)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, targetClosest.position);
        }

        if (longest)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, targetLongest.position);
        }
    }

}
