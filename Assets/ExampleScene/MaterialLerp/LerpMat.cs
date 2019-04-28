using UnityEngine;
using System.Collections;

public class LerpMat : MonoBehaviour {

    public Material material1;
    public Material material2;
    public float duration = 2.0F;
    void Start()
    {
        //GetComponent<Renderer>().material = material1;
    }
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        GetComponent<Renderer>().material.color = new Color(lerp, lerp, lerp);
        //GetComponent<Renderer>().material.Lerp(material1,material2,lerp);

    }
}
