using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour, IShootable {

	public void OnGettingShot()
	{
		Destroy(gameObject);
	}
}
