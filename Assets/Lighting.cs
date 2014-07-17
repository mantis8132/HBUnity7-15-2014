using UnityEngine;
using System.Collections;

public class Lighting : MonoBehaviour {

	public float offDurationMin;
	public float offDurationMax;
	
	public float onDurationMin;
	public float onDurationMax;
	
	void Start() {
		StartCoroutine(DoOnOff());
	}
	
	IEnumerator DoOnOff() {
		while(true) {
			enabled = false;
			yield return new WaitForSeconds(Random.Range(offDurationMin, offDurationMax));
			enabled = true;
			yield return new WaitForSeconds(Random.Range(onDurationMin, onDurationMax));
		}
	}}