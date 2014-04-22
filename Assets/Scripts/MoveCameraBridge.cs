using UnityEngine;
using System.Collections;

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
		BackgroundSound = GameObject.FindGameObjectWithTag ("OpeningScene");
		transform.Rotate (Vector3.up * (12 * Time.deltaTime), Space.World);
		if (!BackgroundSound.audio.isPlaying) 
		{
			Debug.Log("Inside Loop");
			Application.LoadLevel(4);
		}
	}
}
