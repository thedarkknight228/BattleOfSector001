using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script belongs to scene 5
/// 
/// </summary>

public class ExplosionOnCudeIntroduction : MonoBehaviour 
{
	public GameObject Explosion, Explosion2;
	public FireMissilesBorgIntroduced FireScript;
	// Use this for initialization
	void Start () 
	{
		// Retrieving the script so can use its data in this script
		FireScript = GameObject.FindGameObjectWithTag ("missile1").GetComponent<FireMissilesBorgIntroduced> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if(Input.GetKeyDown("space"))
		//{
			//gameObject.SetActive(true);

		    // If the bool in the retrieved script is true it triggers this and sets the explosions off
			if(FireScript.explode)
			{
				Explosion.gameObject.SetActive(true);
				Explosion2.gameObject.SetActive(true);
				FireScript.explode = false;
			}
			//Explosion2.gameObject.SetActive(true);
		//}
	}
}
