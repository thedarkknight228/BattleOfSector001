using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is not been used
/// 
/// </summary>

public class PicardFire : MonoBehaviour 
{
	public Texture PicardFires;
	public GameObject BackgroundSound;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		BackgroundSound = GameObject.FindGameObjectWithTag ("MainCamera");

		if (!BackgroundSound.audio.isPlaying) 
		{
			Application.LoadLevel(9);
		}
	}

	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0,0, Screen.width, Screen.height), PicardFires);
	}
}
