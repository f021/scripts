using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour 
{

    public Transform target = null;
    public float speed = 1f;
    public float sensivity = 1f;

    void FixedUpdate ()
	{
        if (target != null)
        {
            Vector3 targetDir = target.position - transform.position;
            if (targetDir.magnitude < sensivity)
            {
                float step = speed * Time.deltaTime;
                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
                transform.rotation = Quaternion.LookRotation(newDir);
            }
        }
	}
}
