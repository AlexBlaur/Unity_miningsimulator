using UnityEngine;
using System.Collections;

public class shag : MonoBehaviour {
	
	public AudioClip [] step;
	public float timeOut = 4;
	public float stepTime = 1;
	
	void Update () {
		
		timeOut += Time.deltaTime;
		
		if(Input.GetButton("Vertical") && timeOut>=stepTime || Input.GetButton("Horizontal") && timeOut>=stepTime) {
			timeOut = 0;
			audio.PlayOneShot(step[Random.Range (0, step.Length)], 0.5f);
		}
	}
}