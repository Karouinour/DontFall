using UnityEngine;
using System.Collections;

public class About : MonoBehaviour {

	private Color couleurEntrer = Color.black;
	private Color couleurSortie  = Color.black;
	private int tailleEntrer = 65;
	private int tailleSortie = 50;
	public GUIText m;
	
	
	void OnMouseEnter() {
		m.material.color = couleurEntrer;
		m.fontSize = tailleEntrer;
	}
	
	void OnMouseExit() {
		m.material.color = couleurSortie;
		m.fontSize = tailleSortie;
	}
	
	
	
	void OnMouseUp() { 
		
				if (m.text == "Back")
						Application.LoadLevel (0);
				if (m.text == "Next")
						Application.LoadLevel (16);
		}

}
