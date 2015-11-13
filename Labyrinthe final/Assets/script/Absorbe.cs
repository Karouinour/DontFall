using UnityEngine;
using System.Collections;

public class Absorbe : MonoBehaviour {
	public GameObject s;
	
	
	void OnTriggerEnter(Collider s) {


		if (s.gameObject.tag == "sph") {
			Application.LoadLevel(Application.loadedLevel);
			PlayerPrefs.SetInt("restart", Application.loadedLevel);
			Destroy(s);
		}
		

	}
}