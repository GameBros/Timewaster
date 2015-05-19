using UnityEngine;
using System.Collections;

public class game1Controller : MonoBehaviour {

	public int guyRate;
	public GameObject goodGuy;
	public GameObject badGuy;
	private int guyCounter;
	private bool[] guySequence;
	private int guys;

	// Use this for initialization
	void Start () {
		guyCounter = guyRate;
		guySequence = new bool[5];
		int goodCounter;
		while( goodCounter < 3 )
		{
			for( int i = 0; i < 5; i++ )
			{
				int nextInt = Random.Range(0,2);
				if( nextInt == 1 )
				{
					goodCounter ++;
					guySequence[i] = true;
				}
			}
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if( guyCounter > 0 )
			guyCounter -= 1;
		else
		{
			guyCounter = guyRate;

			//Create next guy
			GameObject nextGuy = badGuy;
			if( guySequence[guys] )
				nextGuy = goodGuy;
		
			Instantiate(nextGuy, new Vector3(-6.5f,0.5f,4.0f), Quaternion.identity);
			guys ++;
		}
	}
}
