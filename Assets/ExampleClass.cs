using UnityEngine;
using System.Collections;

[SelectionBase]
[HelpURL("http://example.com/docs/MyComponent.html")]
public class ExampleClass : MonoBehaviour
{
    [RangeAttribute(1.0f,20.0f)]
    public float aa;
    [MultilineAttribute]
    public string text;
    [Space(100)]
    public Transform target;
    void Update()
    {
        if (target)
            transform.LookAt(target);

    }

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        Debug.Log("After scene is loaded and game is running");
    }

    [RuntimeInitializeOnLoadMethod]
    static void OnSecondRuntimeMethodLoad()
    {
        Debug.Log("SecondMethod After scene is loaded and game is running.");
    }
}
