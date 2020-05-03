using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject ball1;
	public GameObject ball2;
	public GameObject ball3;
	public GameObject ball4;
	public GameObject ball5;

	private float pos1;
	private float pos2;
	private float pos3;
	private float pos4;
	private float pos5;

	// Use this for initialization
	void Start () {
		pos1 = ball1.transform.position.y;
		pos2 = ball2.transform.position.y;
		pos3 = ball3.transform.position.y;
		pos4 = ball4.transform.position.y;
		pos5 = ball5.transform.position.y;

		ball1.GetComponent<Rigidbody> ().useGravity = false;
		ball2.GetComponent<Rigidbody> ().useGravity = false;
		ball3.GetComponent<Rigidbody> ().useGravity = false;
		ball4.GetComponent<Rigidbody> ().useGravity = false;
		ball5.GetComponent<Rigidbody> ().useGravity = false;
	}
	
	public void StartPreseed()
	{
		if (ball1.GetComponent<Rigidbody> ().IsSleeping () &&
		    ball2.GetComponent<Rigidbody> ().IsSleeping () &&
		    ball3.GetComponent<Rigidbody> ().IsSleeping () &&
		    ball4.GetComponent<Rigidbody> ().IsSleeping () &&
		    ball5.GetComponent<Rigidbody> ().IsSleeping ()) 
		{
			ball1.GetComponent<Rigidbody> ().useGravity = true;
			ball2.GetComponent<Rigidbody> ().useGravity = true;
			ball3.GetComponent<Rigidbody> ().useGravity = true;
			ball4.GetComponent<Rigidbody> ().useGravity = true;
			ball5.GetComponent<Rigidbody> ().useGravity = true;

			ball1.transform.position = new Vector3 (ball1.transform.position.x, pos1, ball1.transform.position.z);
			ball2.transform.position = new Vector3 (ball2.transform.position.x, pos2, ball2.transform.position.z);
			ball3.transform.position = new Vector3 (ball3.transform.position.x, pos3, ball3.transform.position.z);
			ball4.transform.position = new Vector3 (ball4.transform.position.x, pos4, ball4.transform.position.z);
			ball5.transform.position = new Vector3 (ball5.transform.position.x, pos5, ball5.transform.position.z);
		}
	}
}
