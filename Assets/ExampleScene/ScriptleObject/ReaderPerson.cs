using UnityEngine;
using System.Collections.Generic;

public class ReaderPerson : MonoBehaviour {

	// Use this for initialization
	void Start () {

        PersonHolder ph = Resources.Load<PersonHolder>("PersonConfig");
        List<Person> persons = ph.persons;
        Debug.Log(persons[0].name);
	}
}
