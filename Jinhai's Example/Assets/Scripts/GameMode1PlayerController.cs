using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode1PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text HPText;
	public int hitPoints;
//	public GameObject RPButton;
	public GameObject RtMButton;

	private Rigidbody rb;
	private int count;

	void Start () {
		count = 0;
		rb = GetComponent<Rigidbody>();	
		rb.isKinematic = false;
//		RPButton.SetActive (false);
		RtMButton.SetActive (false);
		SetCountText ();
		SetHPText ();
	}	

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = 0.5f;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.CompareTag ("Obstacle"))
		{
			hitPoints--;
			SetHPText();
		}
	}

	void SetCountText(){
		countText.text = "Score: " + count.ToString ();
	}

	void SetHPText(){
		HPText.text = "HP: " + hitPoints.ToString ();
		if(hitPoints <= 0){
			HPText.text = "Game Over!";
			rb.isKinematic = true;
//			RPButton.SetActive (true);
			RtMButton.SetActive (true);
		}
	}
}
