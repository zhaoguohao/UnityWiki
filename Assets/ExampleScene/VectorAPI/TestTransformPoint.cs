using UnityEngine;
using System.Collections;

public class TestTransformPoint : MonoBehaviour {

    Vector3 vect = new Vector3(1,1,1);
    // Use this for initialization
    void Start () {
        //Vector3 newvect = transform.TransformPoint(vect);
        //GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = newvect;


        Vector3 newvect2 = transform.InverseTransformPoint(vect);
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(transform);
        cube.transform.localPosition = newvect2;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
