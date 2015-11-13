using UnityEngine;
using System.Collections;

public class MenulevelTimeScore_hard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		string score;
		
		for (int i = 7; i < 13; i++) {
			score= PlayerPrefs.GetString("Time_String_level"+i);
			if (score!=""){
				GameObject.Find("niv"+i+"score").guiText.text = score;	
			}
			else
				GameObject.Find("niv"+i+"score").guiText.text ="Locked";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
