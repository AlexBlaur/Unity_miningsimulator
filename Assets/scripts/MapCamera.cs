using UnityEngine;
using System.Collections;

public class MapCamera : MonoBehaviour {

	public Transform Target; // цель, которая будет изменяться, за чем будет следить камера
	// Use this for initialization

	void LateUpdate () {
		transform.position=new Vector3(Target.position.x,Target.position.y,Target.position.z); //меняются все три параметра, так как у шахты есть еще и уровни
	
	}
}
