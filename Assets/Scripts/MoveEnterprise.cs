using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to scene 5
/// 
/// </summary>

public class MoveEnterprise : MonoBehaviour
{
	float speed = 20;
	public Camera camera1;
	public Camera camera2;
	public GameObject particle1;
	public GameObject particle2;
	// Use this for initialization
	void Start () 
	{
		// Finding the particles coming out of back of the enterprise
		particle1 = GameObject.FindGameObjectWithTag("EnterpriseParticle1");
		particle1.SetActive (false);
		particle2 = GameObject.FindGameObjectWithTag("EnterpriseParticle2");
		particle2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Invoke ("TurnOffCamera", 5.3f);

		// Moving the entrprise 
		transform.position += Vector3.left * speed * Time.deltaTime;
		Invoke ("WarpSpeed", 7.8f);
		Invoke ("ChangeScene",11);
	}

	void WarpSpeed()
	{
		// Turning on the particles and setting the speed of the ship up so it moves faster
		particle1.SetActive (true);
		particle2.SetActive (true);
		speed += 5;
	}

	void TurnOffCamera()
	{
		// This just switches the camera 
		camera1.enabled = false;
		camera2.enabled = true;
	}

	void ChangeScene()
	{
		Application.LoadLevel (5);
	}
}
