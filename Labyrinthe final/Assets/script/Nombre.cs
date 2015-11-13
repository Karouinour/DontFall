using UnityEngine;
using System.Collections;

public class Nombre : MonoBehaviour {
	
	public GameObject obstacle;
	
	
	float timeElapsed = 0;
	float spawnCycle = 0.5f;
	
	
	void Update () {
		timeElapsed += Time.deltaTime;
		if(timeElapsed > spawnCycle)
		{
			GameObject temp;
			
			temp = (GameObject)Instantiate(obstacle);
			Vector3 pos = temp.transform.position;
			temp.transform.position = new Vector3(Random.Range(1, 5), pos.y, pos.z);
			
			
			timeElapsed -= spawnCycle;
			
		}
	}
}
