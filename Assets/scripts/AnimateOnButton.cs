using UnityEngine;
using System.Collections;

public class AnimateOnButton : MonoBehaviour {

	//public Animator FirstAnimation; // анимация, которая проигрывается первой
	//public GameObject SecObject;
	public GameObject SecondAnimation; // анимация, которая запускается второй
	public GameObject HelpTooltip;
	// Use this for initialization


	void Start () {
		//FirstAnimation = GetComponent<Animator>();
		//SecondAnimation = GetComponent<Animator>();
		//FirstAnimation.animation.Stop ();
		SecondAnimation.animation.Stop ();
		//SecondAnimation.animation.wrapMode = WrapMode.Loop;	
	}

	/*void OnUpdate()
	{
		if (!SecondAnimation.animation.isPlaying & SecondAnimation.audio.isPlaying) {
			SecondAnimation.audio.Stop();
		} else {
			if (SecondAnimation.animation.isPlaying & !SecondAnimation.audio.isPlaying){
				//Debug.Log(SecondAnimation.audio.isActiveAndEnabled);
				SecondAnimation.audio.Play();
				//Debug.Log(SecondAnimation.audio.isPlaying);
			}
		}

	}
*/
	void OnTriggerEnter(Collider collision){
		HelpTooltip.SetActive (true);
	}
	void OnTriggerExit(Collider collision){
		HelpTooltip.SetActive (false);
	}
	void OnTriggerStay(Collider collision){
		if (collision.CompareTag ("MainCamera")) {
			if (!SecondAnimation.animation.isPlaying & Input.GetKeyUp (KeyCode.E)) {
				//FirstAnimation.animation.Play ();
				//Debug.Log("WHAAAAAT");
				SecondAnimation.animation.Play();
				//SecondAnimation.audio.Play();

			} else {
				if (SecondAnimation.animation.isPlaying & Input.GetKeyUp (KeyCode.E)) {
					//FirstAnimation.animation.Stop ();
					SecondAnimation.animation.Stop();
					//SecondAnimation.audio.Stop();
				}
			}
		}
	
	}
}
/*
 * void OnTrigger(Collider collision)
	{
		if(collision.collider.tag=="Player")
		{
			prohComb.animation.Play ("proComb_animation");
		}
	}
	*/