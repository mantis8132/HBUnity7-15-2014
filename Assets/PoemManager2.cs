using UnityEngine;
using System.Collections;

public class PoemManager2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Debug.Log ( "Hello World" ); 
		
		GetComponent<TextMesh>().text = "The sky blue the river free...";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
