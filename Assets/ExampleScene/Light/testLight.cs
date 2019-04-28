using UnityEngine;
using System.Collections;

public class testLight : MonoBehaviour {

    private Light _light;
    public Color a;
    public Color b;
    public float duration = 2f;

	// Use this for initialization
	void Start () {
        _light = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {

        float t = Mathf.PingPong(Time.time, duration) / duration;
        _light.color = Color.Lerp(a, b, t);
    }
}
