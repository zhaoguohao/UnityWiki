using UnityEngine;
using System.Collections;
using UnityEditor;

public class PersonEditor : Editor {

    [MenuItem("Qiku/BuildAsset")]
	public static void GenericPersonsAsset()
    {
        //初始化holder的事例
        PersonHolder holder = ScriptableObject.CreateInstance<PersonHolder>();

        Person p1 = new Person();
        p1.name = "yupu1";
        p1.age = 1;
        p1.id = 1;
        Person p2 = new Person();
        p2.name = "yupu2";
        p2.age = 2;
        p2.id = 2;

        //添加holder的数据
        holder.persons.Add(p1);
        holder.persons.Add(p2);

        //序列化holder为asset文件
        string path = "Assets/PersonConfig.asset";
        AssetDatabase.CreateAsset(holder,path);

        Debug.Log("Asset Create Success!");
    }
}
