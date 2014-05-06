using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to scene 2
/// 
/// </summary>

public class MovePlanetIntro2 : MonoBehaviour
{
	public float speed = 50;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// This moves the planet towards the sun
		transform.position += new Vector3 (-0.36f, -0.2f, 0.00000000001f);
		Invoke ("ChangeScene", 6.0f);
	}

	void ChangeScene()
	{
		Application.LoadLevel (2);
	}
}
