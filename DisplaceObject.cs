using UnityEngine;
using System.Collections;

public class DisplaceObject : MonoBehaviour 
{

    [SerializeField]
    private Vector3 localForward;
    [SerializeField]
    private Vector3 transformedForward;

	
	void FixedUpdate () 
	{
        localForward = Vector3.forward;
        transformedForward = transform.TransformDirection(localForward);
	}
}
