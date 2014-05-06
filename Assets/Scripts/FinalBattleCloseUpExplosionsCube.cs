using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is not used. 
/// 
/// </summary>

public class FinalBattleCloseUpExplosionsCube : MonoBehaviour 
{
	private float Counter = 0.0f;
	public GameObject Explosion1, Explosion2, Explosion3;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Counter += Time.deltaTime;

		if(Counter > 8.5f && Counter <= 10.9f)
		{
			//Explosion1.gameObject.SetActive(true);
			//Explosion2.gameObject.SetActive(true);
			//Explosion3.gameObject.SetActive(true);
		}
		/*else if(Counter > 8.7f && Counter <= 8.8f)
		{
			Explosion2.gameObject.SetActive(true);
		}
		else if(Counter > 8.8f && Counter <= 8.9f)
		{
			Explosion3.gameObject.SetActive(true);
		}*/
	}
}
