using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is not been used
/// 
/// </summary>

public class OpeningSceneToBattle : MonoBehaviour 
{
	public Texture Cockpit;
	public GameObject BackgroundSound;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		BackgroundSound = GameObject.FindGameObjectWithTag ("OpeningScene");
		if (!BackgroundSound.audio.isPlaying) 
		{
			Application.LoadLevel(2);
		}
	}

	void OnGUI()
	{
		GUI.DrawTexture (new Rect(0,0,Screen.width, Screen.height),Cockpit);
	}
}
