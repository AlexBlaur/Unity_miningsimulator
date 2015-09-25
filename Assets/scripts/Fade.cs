using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fade : MonoBehaviour {

	public float timer;
	public Text BlindText;
	private Color ColorStart;
	public Color ColorFinish;
	private float _time;
	public float LerpSpeed=0.2F;
	// Use this for initialization
	void Start () {
		ColorStart = BlindText.color;
	}
	
	// Update is called once per frame
	void Update () {

		if (timer > 0) {
			timer-=Time.deltaTime;
		}
		if (timer < 0)
		{
			_time+=Time.deltaTime;
			BlindText.color = Color.Lerp (ColorStart, Color.clear, _time*LerpSpeed); // цвет начала, цвет конца, скорость изменения
		}
	
	}
}
