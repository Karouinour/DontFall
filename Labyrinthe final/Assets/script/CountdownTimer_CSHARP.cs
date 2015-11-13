
using UnityEngine;
using System.Collections;

public class CountdownTimer_CSHARP : MonoBehaviour 
{
	// For our timer we will use minutes and seconds
	public GameObject s;

	public float Seconds = 0;
	public float Minutes = 0;


	
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
	void OnTriggerEnter(Collider s) {
		
		if (s.gameObject.tag == "sph") {

			float minute = PlayerPrefs.GetFloat("Time_Minutes_level"+Application.loadedLevel);
			float second = PlayerPrefs.GetFloat("Time_Seconds_level"+Application.loadedLevel);
			if(minute<=Minutes && second<=second){
			PlayerPrefs.SetFloat("Time_Minutes_level"+Application.loadedLevel,Minutes);
			PlayerPrefs.SetFloat("Time_Seconds_level"+Application.loadedLevel,Seconds);
			PlayerPrefs.SetString("Time_String_level"+Application.loadedLevel,Minutes.ToString("f0") + ":" + Seconds.ToString("f0"));
			}
			PlayerPrefs.SetString("Time_String_level"+Application.loadedLevel+1,"00:00");
			if (Application.loadedLevel==12){
				Application.LoadLevel(13);
			}
			Application.LoadLevel (Application.loadedLevel + 1);
		}
	}
}