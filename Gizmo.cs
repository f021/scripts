using UnityEngine;
using System.Collections;

public class Gizmo : MonoBehaviour 
{
    public bool showGizmo = true;

    public enum Shape { WireSphere, Sphere, Cube, WireCube };
    public Shape gizmoShape = Shape.WireSphere; 

    public Color color = new Vector4 (0, 122, 122, 122);

    public float explosionRadius = 1f;
    public float raysLength = 1f;

    public bool rayForward = true;
    public bool rayWorldForward;

    void OnDrawGizmos ()
    {
        if (showGizmo)
        {
            Gizmos.color = color;

            switch (gizmoShape)
            {
                case Shape.WireSphere:
                    Gizmos.DrawWireSphere(transform.position, explosionRadius);
                    break;
                case Shape.Sphere:
                    Gizmos.DrawSphere(transform.position, explosionRadius);
                    break;
                case Shape.Cube:
                    Gizmos.DrawCube(transform.position, Vector3.one * explosionRadius);
                    break;
                case Shape.WireCube:
                    Gizmos.DrawWireCube(transform.position, Vector3.one * explosionRadius);
                    break;
                default:
                    Debug.Log(gizmoShape);
                    break;
            }
        }

        if (rayForward)
        {
            Gizmos.color = Color.blue;
            Vector3 direction = transform.TransformDirection(Vector3.forward) * raysLength;
            Gizmos.DrawRay(transform.position, direction);

//          same
//          Gizmos.color = Color.green;
//          Gizmos.DrawLine(transform.position, transform.position + transform.forward * raysLength);
        
        }
        if (rayWorldForward)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(transform.position, Vector3.forward * raysLength / 2);
        }
    }

}
