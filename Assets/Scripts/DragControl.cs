using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragControl : MonoBehaviour {

	private Vector3 ScreenPoint;
	private Vector3 Offset;

	void OnMouseDown (){

		ScreenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		Offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z));

	}

	void OnMouseDrag (){
	
		Vector3 cursorPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z);
		Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorPoint) + Offset;
		gameObject.transform.position = cursorPosition;

	
	}

}
