using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMoveController : MonoBehaviour{
    
	[Header("Position")]
	public Transform player;
	public float horizontalOffset;

	private void Update(){
		Vector3 newPosition = transform.position;
		newPosition.x = player.position.x + horizontalOffset;
		transform.position = newPosition;
	}
}
