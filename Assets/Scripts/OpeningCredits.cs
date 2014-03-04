using UnityEngine;
using System.Collections;

public class OpeningCredits : MonoBehaviour 
{
	public Texture Credits;
	public Texture Logo;
	private float CreditHeightMove = 0.25f;
	public float Count = 9;
	public OpeningTitles OpeningTitlesScript;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		Count -= Time.deltaTime;
		Debug.Log (Count);
		if (Count > 0) 
		{
			CreditHeightMove -= 0.003f;
		} 
		else 
		{
			Application.LoadLevel (1);
			//gameObject.SetActive(false);
			//OpeningTitlesScript.gameObject.SetActive(true);
		}
	}

	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Logo);
		GUI.DrawTexture (new Rect (Screen.width * 0.25f, Screen.height * CreditHeightMove, Screen.width * 0.5f, Screen.height * 1.5f), Credits);

	}
}
