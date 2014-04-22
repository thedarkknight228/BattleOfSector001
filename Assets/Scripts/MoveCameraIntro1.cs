using UnityEngine;
using System.Collections;

public class MoveCameraIntro1 : MonoBehaviour 
{
	public GameObject TurnOnLight;
	// Use this for initialization
	void Start () 
	{
		//TurnOnLight = GameObject.Find("Sun");
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += new Vector3(0.105f, 0.2f, 0.5f);
		Invoke ("turnonlight", 6.5f);
		Invoke ("ChangeScene", 7);
	}

	void turnonlight()
	{
		TurnOnLight.SetActive (true);
	}

	void ChangeScene()
	{
		Application.LoadLevel (1);
	}
}
