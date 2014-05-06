using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to scene 5
/// Fires laser to hit the cube
/// 
/// </summary>

public class FireMissilesBorgIntroduced : MonoBehaviour 
{
	public bool explode = false;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Invoke ("FireFirstLaser", 11.0f);
		//transform.position += new Vector3(-0.029f, 0.04f, 0.09f);
		//gameObject.transform.position += Vector3.forward * 1.0f * Time.deltaTime;
	}

	void FireFirstLaser()
	{
		// Moves the laser towards the cube
		transform.position += new Vector3(-0.029f, 0.04f, 0.09f);
	}

	// If the lasers collide with the cube it sets the explode bool to true
	void OnTriggerEnter(Collider theEnterer)
	{
		if(theEnterer.tag == "cube")
		{
			gameObject.SetActive(false);
			explode = true;
		}
	}
}
