using UnityEngine;
using System.Collections;

public class RandomPlacesScript : MonoBehaviour {
	public GameObject parentLabyrinth;
	public GameObject prefab;
	public GameObject[] gameObjectPlaces;
	private Vector3[] places;

	// Use this for initialization
	void Start () {

		places = new Vector3[8];
		int[] randomNumbers = new int[8];
		for(int i=0; i<8; i++){
			int randomNumber = 0;
			bool newNumber = true;
			do{
				randomNumber = Random.Range(0, 12);
				newNumber = true;

				for(int j=0; j<i; j++){
					if(randomNumber == randomNumbers[j]){
						newNumber = false;
					}
				}
			}while(!newNumber);
			randomNumbers[i] = randomNumber;

			//gameObjectPlaces[randomNumber].SetActive(true);
			places[i] = gameObjectPlaces[randomNumber].transform.position;

			GameObject troue = (GameObject)GameObject.Instantiate(prefab, places[i], Quaternion.identity);
			troue.transform.parent = parentLabyrinth.transform;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
