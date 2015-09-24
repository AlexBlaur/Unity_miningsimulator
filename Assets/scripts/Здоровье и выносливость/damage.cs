using UnityEngine; 
using System.Collections; 

public class damage : MonoBehaviour { 
	
	public float lastPositionY = 0f; 
	public float fallDistance = 0f; 
	public Transform player; 
	private CharacterController controller; 
	public PlayerStats Char; // чьи статі
	public float DamageCoef = 1; 
	
	void Awake() { 
		controller = GetComponent<CharacterController>();  

	} 
	
	void Update () { 
		PlayerStats PlayerSt = (PlayerStats)Char.GetComponent("PlayerStats");
		if(lastPositionY > player.transform.position.y) { 
			fallDistance += lastPositionY - player.transform.position.y; 
		} 
		
		lastPositionY = player.transform.position.y; 
		
		//высота при которой отнимаются жизни 
		if(fallDistance >= 2 && controller.isGrounded) { 
			//кол-во отнимаемых жизней 
			//currentHealth -= 5; 
			PlayerSt.CurHealth-=(fallDistance * (DamageCoef + 1));
			ApplyNormal(); 
		} 
		
		if(fallDistance <= 5 && controller.isGrounded) { 
			ApplyNormal(); 
		} 
	} 
	
	void ApplyNormal() { 
		fallDistance = 0; 
		lastPositionY = 0; 
	} 
}