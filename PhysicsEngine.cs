using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PhysicsEngine : MonoBehaviour 
{

    public Vector3 velocityVector;
    public Vector3 netForceVector;
    public float mass;
    public List<Vector3> forceVectorList = new List<Vector3>();
	
	void FixedUpdate () 
   	{  
        transform.position += forceVectorList.Aggregate(velocityVector + netForceVector, (acc, v) => acc + v) / mass * Time.deltaTime;
	}

    void UpdateVelocity()
    {

    }

}
