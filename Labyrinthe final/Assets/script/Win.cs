using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {
	//colllider 
	public GameObject s;

	//time game
	public float Seconds = 0;
	public float Minutes = 0;

	
	
	void OnTriggerEnter(Collider s) {
		
		if (s.gameObject.tag == "sph") {

			Application.LoadLevel(Application.loadedLevel+1);
		}
	}
	void Update()
	{
		
		if(Seconds >= 59)
		{
			
			if(Minutes >= 0 && Seconds>=59)
			{
				Minutes++;
			}
			else
			{
				Minutes = 0;
				Seconds = 0;
				
				GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
			}
			Seconds = 0;
		}
		else
		{
			Seconds += Time.deltaTime;
		}
		
		// These lines will make sure the time is shown as X:XX and not X:XX.XXXXXX
		if(Mathf.Round(Seconds) <= 9)
		{
			GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
		}
		else
		{
			GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
		}
	}
}
