using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour 
{

    public Transform target;
    public float speed = 1f;
    public float sensivity = 10f;
    public float minDinstance = 1f;
	
	void FixedUpdate () 
	{
        Vector3 targetDir = target.position - transform.position;
        float distance = targetDir.magnitude;

        if (distance > minDinstance && distance < sensivity)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
	}
}
