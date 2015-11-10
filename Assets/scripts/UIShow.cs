using UnityEngine;
using System.Collections;

public class UIShow : MonoBehaviour {
	
	private bool MapEnable=false;
	public GameObject LegMap;
	public Transform player; 
	public PlayerBarDisplay Bar;
	// Use this for initialization
	void Start () {
		LegMap.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		PlayerBarDisplay Bare = (PlayerBarDisplay)Bar.GetComponent("PlayerBarDisplay");
		if (!MapEnable & Input.GetKeyDown(KeyCode.H))
		{
			MapEnable=true;
			Bare.Visible=false;
			LegMap.SetActive(true);
		}
		else
		{
			if (MapEnable & Input.GetKeyUp(KeyCode.H))
			{
				LegMap.SetActive(false);
				MapEnable=false;
				Bare.Visible=true;
			}
		}
	
	}
}
