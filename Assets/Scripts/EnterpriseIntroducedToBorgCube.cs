using UnityEngine;
using System.Collections;

public class EnterpriseIntroducedToBorgCube : MonoBehaviour 
{
	public Camera camera1;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.position += new Vector3(0.01f, 0.0000000000001f, 0.0000000000001f);
	}
}
