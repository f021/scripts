using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{
  	
    public float speed = 1f;

    void FixedUpdate () 
	{
        transform.position += transform.forward * speed * Time.deltaTime;
	}
}
