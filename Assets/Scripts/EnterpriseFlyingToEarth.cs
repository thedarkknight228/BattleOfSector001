﻿using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is not been used
/// 
/// </summary>

public class EnterpriseFlyingToEarth : MonoBehaviour
{
	public Texture Sky;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Sky);
	}
}
