using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[RequireComponent (typeof(PhysicsEngine))]

public class DrawForces : MonoBehaviour 
{

    public bool showForces;

    private List<Vector3> forceVectorList;

    void OnDrawGizmos()
    {
        if (!showForces)
            return;
        
        forceVectorList = GetComponent<PhysicsEngine>().forceVectorList;

        Gizmos.color = Color.cyan;
        forceVectorList.ForEach(RayTo);

        Gizmos.color = Color.red;
        RayTo(forceVectorList.Aggregate(Vector3.zero, (acc, vector) => acc + vector));
    }
        

    void RayTo (Vector3 vec)
    {
        Gizmos.DrawRay(transform.position, vec);
    }

}
