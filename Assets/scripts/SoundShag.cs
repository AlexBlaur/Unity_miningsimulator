using UnityEngine;
using System.Collections;

public class SoundShag : MonoBehaviour {

	public float speed = 1.0F;
	public float gravity = 20.0F;
	public AudioClip step;
	private float timeout;
	public float footstepTime = 0.7f;
	private Vector3 moveDirection = Vector3.zero;
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded)
		{
			timeout+= Time.deltaTime;
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if(Input.GetButton("Vertical")&timeout>=footstepTime||Input.GetButton("Horizontal")&timeout>=footstepTime)
			{
				timeout = 0;
				audio.PlayOneShot(step);   
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}
