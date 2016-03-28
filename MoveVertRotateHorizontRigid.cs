using UnityEngine;
using System.Collections;

public class MoveVertRotateHorizontRigid : MonoBehaviour 
{

    public float speed = 10f;
    public float rotateSpeed = 60f;

    void FixedUpdate () 
    {
        float movement = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        GetComponent<CharacterController>().SimpleMove(transform.forward * movement);
        transform.rotation *= Quaternion.Euler(new Vector3(0f, rotation, 0f));
    }
}
