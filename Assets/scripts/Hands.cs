using UnityEngine;
using System.Collections;

public class Hands : MonoBehaviour {
	// Use this for initialization
	void Start () {
		animation.Play ("idle");
	}	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			animation.Play("click");
		} else {
			// анимация проигрывается только по окончанию текущей
				animation.CrossFadeQueued ("idle");
			}
	}
}
