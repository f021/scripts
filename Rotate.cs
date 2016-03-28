using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
    public enum RotateType { Quaternion, EulerAngel, QuaternionMultiply };
    public RotateType type = RotateType.EulerAngel;

    public enum RotateAround { World, Self };
    public RotateAround around = RotateAround.Self;

    public float x = 0f;
    public float y = 0f;
    public float z = 0f;

    public float speed = 100f;
	
	void FixedUpdate () 
	{
        switch (type)
        {
            case RotateType.EulerAngel:
                rotate();
                break;
            case RotateType.Quaternion:
                quaternion();
                break;
            case RotateType.QuaternionMultiply:
                quaternionMyltiply();
                break;
            default:
                Debug.Log(type);
                break;
        }
	}

    void quaternion ()
    {
        transform.rotation = Quaternion.Euler(x, y, z);
    }

    void quaternionMyltiply ()
    {
        transform.rotation *= Quaternion.AngleAxis(Time.deltaTime * speed, new Vector3(x, y, z));
    }

    void rotate ()
    {
        transform.Rotate(
            new Vector3 (x, y, z),
            Time.deltaTime * speed,
            around == RotateAround.World ? Space.World : Space.Self
        );
    }
}
