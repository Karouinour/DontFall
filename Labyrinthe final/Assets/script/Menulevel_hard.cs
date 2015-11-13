using UnityEngine;
using System.Collections;

public class Menulevel_hard : MonoBehaviour {

	
	private Color couleurEntrer = Color.gray;
	private Color couleurSortie  = Color.white;
	private int tailleEntrer = 65;
	private int tailleSortie = 50;
	//public GUIText m;
	
	
	
	bool[] niv = new bool[15];
	
	
	
	// Use this for initialization
	void Start () {	

		for (int i = 7; i < 13; i++) {
			niv[i]=false;
		}
		
		string score;
		for (int i = 7; i < 13; i++) {
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
		
		if (gameObject.guiText.name == ("Home"))
			Application.LoadLevel (0);
		if (gameObject.guiText.name ==("Back"))
			Application.LoadLevel(14);
		if (gameObject.guiText.name == ("niv7")&& niv[7])
			Application.LoadLevel(7);
		if (gameObject.guiText.name == ("niv8")&& niv[8])
			Application.LoadLevel(8);
		if (gameObject.guiText.name == ("niv9")&& niv[9]) 
			Application.LoadLevel(9);
		if (gameObject.guiText.name == ("niv10")&& niv[10]) 
			Application.LoadLevel(10);
		if (gameObject.guiText.name == ("niv11")&& niv[11]) 
			Application.LoadLevel(11);
		if (gameObject.guiText.name == ("niv12")&& niv[12]) 
			Application.LoadLevel(12);
	
		
		
	}
	
	
	
	
}
