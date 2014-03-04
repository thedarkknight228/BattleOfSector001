using UnityEngine;
using System.Collections;

public class DefiantShootingBorgFirstScene : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Invoke ("NextScene",9);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void NextScene()
	{
		Application.LoadLevel (6);
	}
}
