using UnityEngine;
using System.Collections;

public class PoemManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ( "Hello World" ); 

		GetComponent<TextMesh>().text = "As written on my \nbottle of tea...";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
