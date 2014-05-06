using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to scene 4
/// 
/// </summary>

public class MoveCameraBridge : MonoBehaviour 
{
	public GameObject BackgroundSound;
	//public Camera Camera1;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Find the background sound with tag
		BackgroundSound = GameObject.FindGameObjectWithTag ("OpeningScene");

		// Rotate the camera around the enterprise bridge

		transform.Rotate (Vector3.up * (12 * Time.deltaTime), Space.World);

		// Once sound is finished change the scene
		if (!BackgroundSound.audio.isPlaying) 
		{
			Application.LoadLevel(4);
		}
	}
}
