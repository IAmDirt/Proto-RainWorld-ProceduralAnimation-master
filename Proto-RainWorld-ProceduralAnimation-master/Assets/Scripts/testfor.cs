using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testfor : MonoBehaviour {
	public int ti = 10;
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < ti +1; i++)
		{
			Debug.Log (i);
		}	
	}
}