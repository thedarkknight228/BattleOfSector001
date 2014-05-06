using UnityEngine;
using System.Collections;

public class OpeningCredits : MonoBehaviour 
{
	public Texture Credits;
	public Texture Logo;
	private float CreditHeightMove = 0.25f;
	public float Count = 14;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Setting up a counter so that the credits keep scrolling till the counter is less than zero
		Count -= Time.deltaTime;

		if (Count >= 0) 
		{
			// This increments the height of the transparent image from the ongui function below
			// Makes the image move upwards and gives the effect of scrolling credits
			CreditHeightMove -= 0.001f;
		} 
	}

	void OnGUI()
	{
		// This is just an image of stars for the background of the credits 
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Logo);
		// This is the credits that will be displayed on the screen. The height of it gets updated so it moves upwards
		GUI.DrawTexture (new Rect (Screen.width * 0.25f, Screen.height * CreditHeightMove, Screen.width * 0.5f, Screen.height * 1.5f), Credits);

	}
}
