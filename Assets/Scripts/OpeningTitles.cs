using UnityEngine;
using System.Collections;

public class OpeningTitles : MonoBehaviour 
{
	public Texture Words;
	public Texture Logo;

	//public GameObject OpeningText = GameObject.Find("OpeningTitle");

	private float WordsWidth = 0.8f;
	private float WordsHeight = 0.4f;
	private float WordWidthMove = 0.1f;
	private float WordHeightMove = 0.3f;

	public OpeningCredits OpeningCreditsScript;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		OpeningCreditsScript.Count -= Time.deltaTime;

		if(OpeningCreditsScript.Count < 1.0f) 
		{
			//gameObject.SetActive(true);
			WordsWidth -= 0.003f;
			WordsHeight -= 0.0014f;
			WordWidthMove += 0.0015f;
			WordHeightMove += 0.001f;
		}

		if (WordsWidth < 0.0f) 
		{
			Application.LoadLevel(1);
		}
	}

	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Logo); 
		if (OpeningCreditsScript.Count < 1.0f) 
		{
			GUI.DrawTexture (new Rect (Screen.width * WordWidthMove, Screen.height * WordHeightMove, Screen.width * WordsWidth, Screen.height * WordsHeight), Words);
		}
	}
}
