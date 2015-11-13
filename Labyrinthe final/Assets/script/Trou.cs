using UnityEngine;
using System.Collections;

public class Trou : MonoBehaviour {
	
	public float objectSpeed = -0.5f;
	
	void Update () {
		transform.Translate(0, objectSpeed, 0);
		
	}
}

