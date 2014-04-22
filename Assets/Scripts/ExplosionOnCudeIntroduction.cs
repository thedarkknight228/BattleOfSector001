using UnityEngine;
using System.Collections;

public class ExplosionOnCudeIntroduction : MonoBehaviour 
{
	public GameObject Explosion, Explosion2;
	public FireMissilesBorgIntroduced FireScript;
	// Use this for initialization
	void Start () 
	{
		FireScript = GameObject.FindGameObjectWithTag ("missile1").GetComponent<FireMissilesBorgIntroduced> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if(Input.GetKeyDown("space"))
		//{
			//gameObject.SetActive(true);
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
