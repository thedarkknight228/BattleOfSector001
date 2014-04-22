using UnityEngine;
using System.Collections;

public class BorgIntroduced : MonoBehaviour 
{
	public Camera camera1;
	public GameObject BackgroundSound;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		BackgroundSound = GameObject.FindGameObjectWithTag ("MainCamera");

		transform.position += new Vector3(0.0006f, 0.0000000000001f, 0.0000000000001f);

		if (!BackgroundSound.audio.isPlaying) 
		{
			Application.LoadLevel(6);
		}

		//Invoke ("NextScene", 6f);
	}

	void NextScene()
	{
		Application.LoadLevel (6);
	}
}
