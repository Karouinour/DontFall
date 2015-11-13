
using UnityEngine;
using System.Collections;

public class Menulevel : MonoBehaviour {


		private Color couleurEntrer = Color.gray;
		private Color couleurSortie  = Color.white;
		private int tailleEntrer = 65;
		private int tailleSortie = 50;
		//public GUIText m;



	bool[] niv = new bool[10];


		
	// Use this for initialization
	void Start () {	
		niv [1] = true;
		for (int i = 2; i < 7; i++) {
					niv[i]=false;
				}

		string score;
		for (int i = 1; i < 7; i++) {
			score= PlayerPrefs.GetString("Time_String_level"+i);
			if (score!=""){
				GameObject.Find("niv"+i+"score").guiText.text = score;
				niv[i] =true;
			}
			else
				GameObject.Find("niv"+i+"score").guiText.text ="Locked";
				}

	}
		
		void OnMouseEnter() {

		gameObject.guiText.material.color = couleurEntrer;
		gameObject.guiText.fontSize = tailleEntrer;
	
		}
		
		void OnMouseExit() {
	
		gameObject.guiText.material.color = couleurSortie;
		gameObject.guiText.fontSize = tailleSortie;

		}
		
		
		
		void OnMouseUp() { 
			
		if (gameObject.guiText.name ==("Nex"))
			Application.LoadLevel(13);
		if (gameObject.guiText.name ==("Home"))
				Application.LoadLevel(0);
		if (gameObject.guiText.name == ("niv1"))
			Application.LoadLevel(1);
		if (gameObject.guiText.name == ("niv2")&& niv[2])
			Application.LoadLevel(2);
		if (gameObject.guiText.name == ("niv3")&& niv[3]) 
			Application.LoadLevel(3);
		if (gameObject.guiText.name == ("niv4")&& niv[4]) 
			Application.LoadLevel(4);
		if (gameObject.guiText.name == ("niv5")&& niv[5]) 
			Application.LoadLevel(5);
		if (gameObject.guiText.name == ("niv6")&& niv[6]) 
			Application.LoadLevel(6);
	

			
		}
		
		
		
		
	}
