using UnityEngine;
using System.Collections;

public class AnimateOnButton : MonoBehaviour {

	public GameObject SecondAnimation; // анимация, которая запускается второй
	public GameObject HelpTooltip;
	// Use this for initialization
	void Start () {
		SecondAnimation.animation.Stop ();
	}

	void OnTriggerEnter(Collider collision){
		HelpTooltip.SetActive (true);
	}
	void OnTriggerExit(Collider collision){
		HelpTooltip.SetActive (false);
	}
	void OnTriggerStay(Collider collision){
		if (collision.CompareTag ("MainCamera")) {
			if (!SecondAnimation.animation.isPlaying & Input.GetKeyUp (KeyCode.E)) {
				SecondAnimation.animation.Play();
				SecondAnimation.audio.Play ();
			} else {
				if (SecondAnimation.animation.isPlaying & Input.GetKeyUp (KeyCode.E)) {
					SecondAnimation.animation.Stop();
					SecondAnimation.audio.Stop();
				}
			}
		}
	
	}
}