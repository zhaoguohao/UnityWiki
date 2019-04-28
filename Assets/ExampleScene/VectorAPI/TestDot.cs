using UnityEngine;
using System.Collections;

public class TestDot : MonoBehaviour {

    public Transform T1;
    public Transform T2;

    void Start () {
	
	}
	
	void Update () {
        //点积的返回值 
        float dot = Vector3.Dot(T1.position, T2.position);
        //向量a,b的夹角,得到的值为弧度，我们将其转换为角度，便于查看！  
        float angle = Mathf.Acos(Vector3.Dot(T1.position.normalized, T2.position.normalized)) * Mathf.Rad2Deg;

        Debug.DrawLine(Vector3.zero, T1.position, Color.blue);
        Debug.DrawLine(Vector3.zero, T2.position, Color.red);
        Debug.DrawLine(Vector3.zero, Vector3.forward* dot, Color.black);

        Debug.Log("angle:" + angle);
    }
}
