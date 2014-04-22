using UnityEngine;
using System.Collections;

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
		Invoke ("FireFirstLaser", 12.0f);
		//transform.position += new Vector3(-0.029f, 0.04f, 0.09f);
		//gameObject.transform.position += Vector3.forward * 1.0f * Time.deltaTime;
	}

	void FireFirstLaser()
	{
		transform.position += new Vector3(-0.029f, 0.04f, 0.09f);
	}

	void OnTriggerEnter(Collider theEnterer)
	{
		if(theEnterer.tag == "cube")
		{
			gameObject.SetActive(false);
			explode = true;
		}
	}
}
