using UnityEngine;
using System.Collections;

public class ColliderHit : MonoBehaviour {
	//public GlobalFog script2Reference;
	public GameObject Object; //музыка
	public GameObject animObj; //анимация
	public int hitman=50;
	//public GameObject camObj; //камера
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider all)
	{
		if (all.gameObject.CompareTag ("MainCamera")) {
			if (animObj.animation.isPlaying) {
				// проиграть звук вскрика
				Object.audio.Play ();
				//окрасить камеру красным цветом
				NoiseEffect target = (NoiseEffect)FindObjectOfType(typeof(NoiseEffect));
				target.enabled=true;
				//уменьшить здоровье и постепенно уменьшать до нуля. После чего - ресет игры
				damage Dam = (damage)FindObjectOfType(typeof(damage));
				Dam.DamageHealth(hitman);
			}
		}

	}
	void OnTriggerExit(Collider all)
	{
		NoiseEffect target = (NoiseEffect)FindObjectOfType(typeof(NoiseEffect));
		target.enabled=false;
	}
	/*void OnControllerColliderHit(ControllerColliderHit all)
	{
		//Debug.Log("Hit Something "+all.gameObject.tag);
		if (all.gameObject.CompareTag ("Mecanism")) {
			Debug.Log("Hit Something "+all.gameObject.tag);
			if (all.gameObject.animation.isPlaying) {
				//Debug.Log ("Anim " + animObj.tag);
				// проиграть звук вскрика
				Object.audio.Play ();
				//audio.PlayOneShot (scream); // проиграть один раз
				//окрасить камеру красным цветом (поменять fog на красный и через некоторое время вернуть черный)
				//уменьшить здоровье и постепенно уменьшать до нуля. После чего - ресет игры
			}
		}

	}*/
}
