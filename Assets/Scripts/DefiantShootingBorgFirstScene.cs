using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to the scene 6
/// This script is just used to change the scene when the music stops playing 
/// 
/// </summary>

public class DefiantShootingBorgFirstScene : MonoBehaviour 
{
	public GameObject BackgroundSound, Cube, CloneShips;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!BackgroundSound.audio.isPlaying) 
		{
			Cube.gameObject.SetActive(false);
			CloneShips.gameObject.SetActive(false);
			BackgroundSound.gameObject.SetActive(false);
			Application.LoadLevel(7);
		}
	}
}
