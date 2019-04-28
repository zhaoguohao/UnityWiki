using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {

    public float speed = 1000f;
    private Rigidbody rididBody;
    private Vector3 m_Move;
    // Use this for initialization
    void Start () {
        rididBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        m_Move = v * transform.forward + h * transform.right;
        rididBody.AddForce(m_Move* speed, ForceMode.Impulse);

        Debug.DrawLine(transform.position, transform.position + m_Move * speed, Color.blue);
    }
}
