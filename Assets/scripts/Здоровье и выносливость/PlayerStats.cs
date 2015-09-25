/// <summary>
/// Player stats.
/// Хранит данные о игроке
/// Вешать на игрока
/// </summary>
using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	
	//public int LVL;
	//public GameObject Target;
	public float MaxHealth; // Максимальное количество здоровья
	public float CurHealth; // Текущее количество здоровья
	public float MaxStamina; // Максимально количество выносливости
	public float CurStamina; // Текущее количество выносливости
	public float UpStamina; // Количество восстанавливаемой в процессе отдыха выносливости

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
