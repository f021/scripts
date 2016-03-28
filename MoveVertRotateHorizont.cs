using UnityEngine;
using System.Collections;

public class MoveVertRotateHorizont : MonoBehaviour 
{
	
    public float speed = 10f;
    public float rotateSpeed = 5f;

	void Update () 
	{
        float movement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;

        transform.position += transform.forward * movement;
        transform.rotation *= Quaternion.Euler(new Vector3(0f, rotation, 0f));
	}
}
