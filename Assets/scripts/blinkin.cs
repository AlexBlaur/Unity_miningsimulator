using UnityEngine;
using System.Collections;

public class blinkin : MonoBehaviour {
	public Transform lamp; // для собственно объявления лампы
	private int rand; // используется для рандома

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rand = Random.Range(0,1000);
		if(rand >= 980)
		{
			lamp.light.enabled = false;
		}
		else
		{
			lamp.light.enabled = true;
		}	
	}
}
