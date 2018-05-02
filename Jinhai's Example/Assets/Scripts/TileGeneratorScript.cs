using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileGeneratorScript : MonoBehaviour {

	public GameObject player;
	public GameObject tile;
	public Text countText;

	private int n;
	private	int m;
	private	int a;
	private	int b;
	private	int c;

	// Use this for initialization
	void Start () {
		n = 0;
		m = 0;
		cloneTile ();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.z >= this.transform.position.z + m - 20){
			cloneTile ();
			n++;
			countText.text = "Count: " + n.ToString ();
		}
	}

	void cloneTile(){
		a = Random.Range(0,9);
		b = Random.Range(0,9);
		c = Random.Range(0,9);
		GameObject temp = Instantiate(tile, new Vector3 (0.0f, 0.0f, this.transform.position.z + m + 20), new Quaternion (0, 0, 0, 45), transform); 
		temp.SetActive(true);
		for (int i = 0; i < temp.transform.childCount; i++) {
			if (temp.transform.GetChild (i).name == "Obstacles") {
				for (int j = 0; j < temp.transform.GetChild (i).childCount; j++) {
					if(j != a && j != b && j != c){
						temp.transform.GetChild (i).GetChild(j).gameObject.SetActive (true);
					}
				}
			}
		}
		m = m + 20;
	}
		
}
