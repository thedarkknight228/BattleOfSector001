using UnityEngine;
using System.Collections;

public class MoveEnterprisePastBorg : MonoBehaviour 
{
	float speed = 5;
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
