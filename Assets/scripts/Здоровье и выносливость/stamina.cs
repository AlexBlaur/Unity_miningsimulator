using UnityEngine;
using System.Collections;

public class stamina : MonoBehaviour {
	public float speed = 1.0F;
	public float gravity=10;
	public float dumpTime = 3f;
	private float _speed;

	public Transform player; 
	public PlayerStats Char;

	void Start()
	{
		PlayerStats PlayerSt = (PlayerStats)Char.GetComponent("PlayerStats");
		_speed = PlayerSt.MaxStamina*1/dumpTime;
	}

	private Vector3 moveDirection = Vector3.zero;
	void Update() {
		PlayerStats PlayerSt = (PlayerStats)Char.GetComponent("PlayerStats");
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) { // наша тлень на земле
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			//if (PlayerSt.CurStamina>=0)
			if (Input.GetButton("Run") & PlayerSt.CurStamina>0) // если нажата кнопка бега и выносливость не нулевая
			{
				moveDirection *= 4;
				PlayerSt.CurStamina = Mathf.MoveTowards((float)PlayerSt.CurStamina, 0, _speed*Time.deltaTime);
			}
			else 
			{
				if (PlayerSt.CurStamina<PlayerSt.MaxStamina & !Input.GetButton("Run"))
				{
					PlayerSt.CurStamina+=PlayerSt.UpStamina*Time.deltaTime; // за 1 секунду будет изменяться выносливость на UpStamina единиц
				}
			}
			
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}