using UnityEngine;
using System.Collections;

public class TestCross : MonoBehaviour {

    public Transform T1;
    public Transform T2;

    void Start () {
        T1.gameObject.layer = 10;
	}
	
	void Update () {
        Vector3 cross = Vector3.Cross(T1.position, T2.position);

        Debug.DrawLine(Vector3.zero, T1.position, Color.blue);
        Debug.DrawLine(Vector3.zero, T2.position, Color.red);
        Debug.DrawLine(Vector3.zero, cross, Color.black);

        Debug.Log(Mathf.Asin(Vector3.Distance(Vector3.zero,Vector3.Cross(T1.position.normalized,T2.position.normalized)))*Mathf.Rad2Deg);
    }
}
