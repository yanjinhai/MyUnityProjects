using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelfDeleteScript : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.z >= this.transform.position.z + 40){
			Destroy (gameObject);
		}
	}
}
