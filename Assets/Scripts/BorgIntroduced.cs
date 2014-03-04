using UnityEngine;
using System.Collections;

public class BorgIntroduced : MonoBehaviour 
{
	public Camera camera1;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += new Vector3(0.006f, 0.0000000000001f, 0.0000000000001f);
		Invoke ("NextScene", 6f);
	}

	void NextScene()
	{
		Application.LoadLevel (5);
	}
}
