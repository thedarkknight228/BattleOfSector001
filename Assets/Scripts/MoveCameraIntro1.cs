using UnityEngine;
using System.Collections;

public class MoveCameraIntro1 : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += new Vector3(0.105f, 0.12f, 0.3f);
	}
}
