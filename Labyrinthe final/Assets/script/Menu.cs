using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	private Color couleurEntrer = Color.black;
	private Color couleurSortie  = Color.black;
	private int tailleEntrer = 90;
	private int tailleSortie = 70;
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

		if (m.text == "Quit")
			Application.Quit();
		if (m.text == "Continue") {
						int mi = 2;
						//int j=7;
						string score;
						bool q = false;
						for (int i = 2; i < 7; i++) {
								score = PlayerPrefs.GetString ("Time_String_level" + i);
								if (score != "") {
										q = true;
										mi = i;
								}
						}
						if (q) {
								Application.LoadLevel (mi);
						} else {
								for (int j = 7; j < 13; j++) {
										score = PlayerPrefs.GetString ("Time_String_level" + j);
										if (score != "") {
												q = true;
												mi = j;
										}
								}
								if (q) {
										Application.LoadLevel (mi);
								}
						}
						Application.LoadLevel (1);
				}


		if (m.text == "New Game")
			Application.LoadLevel(1);
		//PlayerPrefs.DeleteAll ();
		if(m.text=="Levels")
			Application.LoadLevel(14);
		if (m.text == "About")
			Application.LoadLevel (15);
		if (m.text == "How to play")
			Application.LoadLevel (17);


	}
	



}
