using UnityEngine;
using System.Collections;

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
		transform.position += new Vector3 (-0.36f, -0.2f, 0.00000000001f);
		Invoke ("ChangeScene", 6.8f);
	}

	void ChangeScene()
	{
		Application.LoadLevel (2);
	}
}
