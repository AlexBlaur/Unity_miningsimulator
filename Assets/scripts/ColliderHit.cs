using UnityEngine;
using System.Collections;

public class ColliderHit : MonoBehaviour {

	public GameObject Object;
	public AudioClip scream;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision all)
	{
		//AudioSource scr.clip=scream;
		if (all.gameObject.name=="FPS")
		{
			// проиграть звук вскрика
			scream.Play();
			//окрасить камеру красным цветом (поменять fog на красный и через некоторое время вернуть черный)
			//уменьшить здоровье и постепенно уменьшать до нуля. После чего - ресет игры
		}

	}
}
