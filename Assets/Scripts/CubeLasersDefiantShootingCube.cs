using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is belonging to scene 6
/// 
/// </summary>

public class CubeLasersDefiantShootingCube : MonoBehaviour 
{
	public GameObject laser1, laser2, laser3;
	public float Count = 0.0f;
	// Use this for initialization
	void Start () 
	{
		// Finding the three laser game objects so they can be used in this script
		laser1 = GameObject.FindGameObjectWithTag("CubeLaser1");
		laser2 = GameObject.FindGameObjectWithTag("CubeLaser2");
		laser3 = GameObject.FindGameObjectWithTag("CubeLaser3");
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Counter
		Count += Time.deltaTime;

		// This sets off the lasers that are attached to the cube.
		// Using moduler so that they go off at different times
		if(((int)Count) % 2 == 0)
		{
			// Enabling the line renderer so that the laser gets drawn on the scene. 
			laser1.gameObject.GetComponent<LineRenderer>().enabled = true;
			// Invoking a function to turn off lasers after half a second
			Invoke("TurnOffLaser1", 0.5f);
		}
		else if(((int)Count) % 3 == 0)
		{
			laser2.gameObject.GetComponent<LineRenderer>().enabled = true;
			Invoke("TurnOffLaser2", 0.5f);
		}
		else if(((int)Count) % 2 != 0)
		{
			laser3.gameObject.GetComponent<LineRenderer>().enabled = true;
			Invoke("TurnOffLaser3", 0.5f);
		}
	}

	void TurnOffLaser1()
	{
		// Disabling the line renderer from the scene. 
		laser1.gameObject.GetComponent<LineRenderer>().enabled = false;
	}

	void TurnOffLaser2()
	{
		laser2.gameObject.GetComponent<LineRenderer>().enabled = false;
	}

	void TurnOffLaser3()
	{
		laser3.gameObject.GetComponent<LineRenderer>().enabled = false;
	}
}
