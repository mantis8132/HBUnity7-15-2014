using UnityEngine;
using System.Collections;

public class PoemManager1 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Debug.Log ( "Hello World" ); 
		
		GetComponent<TextMesh>().text = "Earth everlasting...";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
