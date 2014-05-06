using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is used for scene 7
/// The script moves the camera and also triggers the lasers and explosions. 
/// 
/// </summary>

public class EnterpriseIntroducedToBorgCube : MonoBehaviour 
{
	public Camera camera1;
	public GameObject BackgroundSound, Enterprise, Defiant, Cube, Explosion1, Explosion2, Laser1, Laser2;
	// Use this for initialization
	void Start () 
	{
		//Laser1.gameObject.GetComponent<LineRenderer>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// This line of code just gradually moves the camera back 
		transform.position += new Vector3(0.02f, 0.0000000000001f, 0.0000000000001f);

		// These invokes are used to trigger the lasers and explosions. 
		Invoke ("TurnOnLaser2", 2.0f);
		Invoke ("TurnOffLaser", 2.4f);
		Invoke ("Explosion", 2.5f);
		Invoke ("TurnOnLaser3", 4.0f);
		Invoke ("TurnOffLaser3", 4.4f);
		Invoke ("Explosion20", 4.5f);

		// Once the sound has stopped playing the scene is changed. 
		if (!BackgroundSound.audio.isPlaying) 
		{
			Enterprise.gameObject.SetActive(false);
			Defiant.gameObject.SetActive(false);
			Cube.gameObject.SetActive(false);
			BackgroundSound.gameObject.SetActive(false);
			Explosion1.gameObject.SetActive (false);
			Application.LoadLevel(8);
		}
	}

	// The following functions are called from the invokes above
	void TurnOffLaser()
	{
		Laser2.gameObject.SetActive (false);
	}

	void TurnOnLaser2()
	{
		Laser2.gameObject.GetComponent<LineRenderer>().enabled = true;
	}

	void Explosion()
	{
		Explosion1.gameObject.SetActive (true);
	}

	void TurnOffLaser3()
	{
		Laser1.gameObject.SetActive (false);
	}
	
	void TurnOnLaser3()
	{
		Laser1.gameObject.GetComponent<LineRenderer>().enabled = true;
	}
	
	void Explosion20()
	{
		Explosion2.gameObject.SetActive (true);
	}
}
