using UnityEngine;
using System.Collections;

public class AnimateOnButton : MonoBehaviour {

	public Animator FirstAnimation; // анимация, которая проигрывается первой
	public Animator SecondAnimation; // анимация, которая запускается второй
	// Use this for initialization
	void Start () {
		SecondAnimation.animation.wrapMode = WrapMode.Loop;	
	}

	
	// Update is called once per frame
	void OnTrigger(Collider collision){
		if (collision.collider.tag == "MainCamera") {
			if (!SecondAnimation.animation.isPlaying & Input.GetKeyUp (KeyCode.E)) {
				FirstAnimation.animation.Play ();
				SecondAnimation.animation.Play ();
			} else {
				if (SecondAnimation.animation.isPlaying & Input.GetKeyUp (KeyCode.E)) {
					FirstAnimation.animation.Stop ();
					SecondAnimation.animation.Play ();
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