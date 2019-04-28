// Draw lines to the connected game objects that a script has.
// if the target object doesnt have any game objects attached
// then it draws a line from the object to 0,0,0.

using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ConnectedObjects))]
class ConnectLineHandle : Editor
{
    float dashSize = 4.0f;
    void OnSceneGUI()
    {
        Handles.ScaleSlider(10f,Vector3.one,Vector3.up,Quaternion.identity,1,1);
        Handles.ArrowCap(0,(target as ConnectedObjects).transform.position +new Vector3(5, 0, 0),
                    (target as ConnectedObjects).transform.rotation,
                    1f);
        Handles.DrawSolidArc(Vector3.one,Vector3.up,Vector3.forward,90f,10f);
        ConnectedObjects connectedObjects = target as ConnectedObjects;
        if (connectedObjects.objs == null)
            return;

        Vector3 center = connectedObjects.transform.position;
        for (int i = 0; i < connectedObjects.objs.Length; i++)
        {
            GameObject connectedObject = connectedObjects.objs[i];
            if (connectedObject)
            {
                Handles.DrawDottedLine(center, connectedObject.transform.position, dashSize);
            }
            else
            {
                Handles.DrawDottedLine(center, Vector3.zero, dashSize);
            }
        }
    }
}