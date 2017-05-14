using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour {
	[SerializeField]
	GameObject box;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnBox());
	}

	//random spawning
	IEnumerator SpawnBox(){
		GameObject spawnedBox = Instantiate(box, transform.position, transform.rotation);
		int forceX = Random.Range(-1000, 1001);
		int forceY = Random.Range(-1000, 1001);
		int forceZ = Random.Range(-1000, 1001);
		Vector3 forceToAdd = new Vector3(forceX, forceY, forceZ);
		//this is pretty important
		spawnedBox.GetComponent<Box>().AddForceToMe(forceToAdd);
		yield return new WaitForSeconds(1);
		StartCoroutine(SpawnBox());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
