using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is belonging to scene 6
/// 
/// </summary>

public class BorgExplosion2Scene2 : MonoBehaviour
{
	public DefiantShootingBorgCube1  DefiantShootingBorgCubeScript;
	public GameObject borgExplode;
	public float Count = 0.0f;

	// Use this for initialization
	void Start () 
	{
		// I am getting access to the script that is attached to a different game object so I can use 
		// and manipulate its data
		DefiantShootingBorgCubeScript = GameObject.FindGameObjectWithTag("missile1").GetComponent<DefiantShootingBorgCube1>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Count += Time.deltaTime;
		// This is another counter that sets the explosion to true so it
		// explodes at a certain point
		if(Count > 5.0f)
		{
			borgExplode.gameObject.SetActive(true);
		}

	}
}
