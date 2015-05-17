using UnityEngine;
using System.Collections;

public class TouchHelper
{
	public static bool Touched(GameObject gameObject){
		return CrossPlatformInput.isTouching()
			&& gameObject.GetComponent<Collider2D> ().OverlapPoint (CrossPlatformInput.TouchPos());
	}
}