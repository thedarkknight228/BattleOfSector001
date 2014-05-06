using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is belonging to scene 6
/// 
/// </summary>

public class DefiantShootingBorgCube : MonoBehaviour 
{
	private float Counter = 0.0f;
	public GameObject Fire, Fire2;
	public bool explode = false;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Counter
		Counter += Time.deltaTime;

		// If the counter is between these seconds it fire the bullets towards the cube
		// else they are set to false
		if(Counter >= 1.5f && Counter <= 4.0f)
		{
			Fire.gameObject.GetComponent<LineRenderer>().enabled = true;
			Fire2.gameObject.GetComponent<LineRenderer>().enabled = true;
			transform.position += new Vector3(0.0f, 0.05f, 0.8f);
		}
		else
		{
			Fire.gameObject.GetComponent<LineRenderer>().enabled = false;
			Fire2.gameObject.GetComponent<LineRenderer>().enabled = false;
		}
	}

	// Once the bullets collide with the cube they set off the explosion by setting it to true.
	void OnTriggerEnter(Collider theEnterer)
	{
		if(theEnterer.tag == "cube")
		{
			gameObject.SetActive(false);
			explode = true;
		}
	}
}
