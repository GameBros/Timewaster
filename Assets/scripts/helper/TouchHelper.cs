using UnityEngine;
using System.Collections;

public class TouchHelper
{
	public static bool Touched(GameObject gameObject){
		return CrossPlatformInput.Touched()
			&& gameObject.GetComponent<Collider2D> ().OverlapPoint (CrossPlatformInput.TouchPos());
	}

	public static bool TouchedScreen(){
		return CrossPlatformInput.Touched();
	}
}