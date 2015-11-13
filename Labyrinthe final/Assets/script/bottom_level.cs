using UnityEngine;
using System.Collections;

public class bottom_level : MonoBehaviour {
	private bool pause = true;
	public GUIText p;
	//private GUIText p;

	// Use this for initialization
	void Start () {
		p.enabled=false;

	}
	
	// Update is called once per frame
	void Update () {



	}


	void OnMouseUp() { 
		if (gameObject.GetComponent<SpriteRenderer>().name == ("home"))
			Application.LoadLevel (0);
		if (gameObject.GetComponent<SpriteRenderer>().name == ("restart"))
			Application.LoadLevel(Application.loadedLevel);
		if (gameObject.GetComponent<SpriteRenderer> ().name == ("playpause"))

				if (pause) {
			p.enabled=true;

						pause = false;
						Time.timeScale = 0;
				} else {
			p.enabled=false;
						Time.timeScale = 1;
						pause = true;
				}
		}
}
