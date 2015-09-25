using UnityEngine;
using System.Collections;

public class TestTrigger : MonoBehaviour {

	public GameObject monstr;
	public bool triggerEnter=false;
	public AudioClip sound;
	
	void Awake ()
	{
		monstr.SetActive(false);
	}
	
	void OnTriggerEnter(Collider all)
	{
		if(triggerEnter == false && all.CompareTag("Player"))
		{
			audio.PlayOneShot(sound);
			triggerEnter = true;
			monstr.SetActive(true);
		}
	}
	void OnTriggerExit()
	{
		monstr.SetActive(false);
	}
}
