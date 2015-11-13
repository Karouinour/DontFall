using UnityEngine;
using System.Collections;

public class labi : MonoBehaviour {
	public GameObject plan;
	public Rigidbody balon;

	public float vitesse =10000.0F;
	public float max = 100.0F;

	// Use this for initialization
	void Start () {	
			//GameObject.Find("BestTime").guiText.text = PlayerPrefs.GetString("Time_String_level"+Application.loadedLevel);
		}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt ("time", 0);

		Vector3 dir = Vector3.zero;
		dir.x = (-Input.acceleration.x*1000)/100;
		dir.y = (-Input.acceleration.y*1000)/100;
		dir.z = 0f;
		balon.AddForce(dir * vitesse * Time.deltaTime);
		Quaternion target = Quaternion.Euler(dir.x, 0f, dir.y);
		plan.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * vitesse);
	
	}

}
