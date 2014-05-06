using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to scene 7
/// Just moving the enterprise past the borg cube
/// 
/// </summary>

public class MoveEnterprisePastBorg : MonoBehaviour 
{
	float speed = 15;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
