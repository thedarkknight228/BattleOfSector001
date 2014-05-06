using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to scene 6
/// 
/// </summary>

public class ExplosionDefiantShootingCube : MonoBehaviour
{
	public float Count = 0.0f;
	public GameObject Explosion;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Counter
		Count += Time.deltaTime;

		// Sets the explosion off when the counter is greater than 5
		if(Count >= 5)
		{
			Explosion.gameObject.SetActive(true);
		}
	}
}
