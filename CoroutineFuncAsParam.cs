using UnityEngine;
using System;
using System.Collections;

public class CoroutineFuncAsParam : MonoBehaviour 
{

    public float min = 0f;
    public float max = 2 * Mathf.PI;
    public float step = 0.1f;

    int PrintInConsole (float n)
    {
        Debug.Log(n);
        transform.position = new Vector3(Mathf.Cos(n), n, Mathf.Sin(n));
        return 0;
    }
	
	void Update () 
	{
        StartCoroutine(CountFromTo(PrintInConsole));
	}

    IEnumerator CountFromTo (Func<float, int> func)
    {
        float counter = min;

        while (true)
        {
            counter += step;

            if (counter > max)
            {
                counter = min;
            }

            func(counter);

            yield return null;
        }
    }
}
