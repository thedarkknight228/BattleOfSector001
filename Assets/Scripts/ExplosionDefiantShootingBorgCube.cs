using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is used in scene 
/// 
/// </summary>

public class ExplosionDefiantShootingBorgCube : MonoBehaviour
{
	public float Counter = 0.0f;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Counter += Time.deltaTime;
		gameObject.SetActive(true);
	}
}
