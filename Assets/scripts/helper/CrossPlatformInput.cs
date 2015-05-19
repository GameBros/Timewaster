using UnityEngine;
using System.Collections;

public class CrossPlatformInput{

	public static bool Touched(){
		if (Application.isEditor) {
			return Input.GetMouseButtonUp (0);
		} else {
			return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended;
		}
	}

	public static Vector2 TouchPos(){
		Vector3 vec;

		if (Application.isEditor) {
			vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		} else {
			vec = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
		}

		return new Vector2(vec.x, vec.y);
	}

}
