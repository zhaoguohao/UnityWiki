using UnityEngine;
using System.Collections;

public class DrawAxis : MonoBehaviour {

    public Transform obj1;
    public Transform obj2;
    public Transform obj3;

    Vector3 a, b, c, d,bin;

    void Start()
    {
        a = obj1.position;
        b = obj2.position;
        c = a;
        d = b;
        bin = obj3.position;

    }
    void Update()
    {
        a = obj1.position;
        b = obj2.position;
        c = a;
        d = b;
        bin = obj3.position;

        Vector3.OrthoNormalize(ref a, ref b,ref bin);
        Debug.DrawLine(Vector3.zero, c, Color.blue);
        Debug.DrawLine(Vector3.zero, d, Color.white);
        Debug.DrawLine(Vector3.zero, a, Color.red);
        Debug.DrawLine(Vector3.zero, b, Color.green);
        Debug.DrawLine(Vector3.zero, bin, Color.yellow);
    }
}
