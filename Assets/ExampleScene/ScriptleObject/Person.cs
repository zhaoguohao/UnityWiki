using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Person {

    public int id;
    public int age;
    public string name;
}

public class PersonHolder : ScriptableObject
{
    public List<Person> persons = new List<Person>();
}
