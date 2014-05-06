using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is used in scene 3.
/// It moves the camera around the scene, moves the enterprise and displays the credits on the screen
/// 
/// </summary>

public class MoveCameraIntro3 : MonoBehaviour 
{
	public float Count = 6;
	public GameObject Enterprise, Enterprise2, Enterprise3;
	public Camera camera1;
	public Camera camera2;
	public GameObject particle1;
	public GameObject particle2;
	public GameObject Planet1;
	public GameObject Planet2;
	public GameObject Logo, Picard, Riker, LaForge, Wolf, Crusher, Troi, Data, Crusher2;
	public Vector3 posEnt1, posEnt2;
	private bool move = true;
	// Use this for initialization
	void Start () 
	{
		// Retrieving all the game objects so they can be manipulated in this file
		Enterprise = GameObject.FindGameObjectWithTag("Enterprise");
		particle1 = GameObject.FindGameObjectWithTag("EnterpriseParticle1");
		particle1.SetActive (false);
		particle2 = GameObject.FindGameObjectWithTag("EnterpriseParticle2");
		particle2.SetActive (false);
		Planet1 = GameObject.FindGameObjectWithTag ("Planet");
		Planet2 = GameObject.FindGameObjectWithTag ("Planet2");

		// Storing the starting positions of the enterprise so can put it back into its position. 
		posEnt1 = new Vector3(Enterprise2.transform.position.x, Enterprise2.transform.position.y, Enterprise2.transform.position.z);
		posEnt2 = new Vector3(Enterprise3.transform.position.x, Enterprise3.transform.position.y, Enterprise3.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Counter
		Count -= Time.deltaTime;

		// The following is all set out to trigger events that happen when the counter hits a certain range of seconds. 
		// Turning camera, moving enterprise, move position of enterprise, displaying credits
		if(Count > 0)
		{
			transform.Rotate (Vector3.up * (15 * Time.deltaTime), Space.World);// += Vector3 (0.0000001f, 0.1f, 0.0000001f);
			if(Count < 1)
			{
				transform.position += Vector3.right * 50 * Time.deltaTime;
			}
		}
		else if(Count <= 0 && Count > -4.5)
		{
			transform.position += Vector3.right * 50 * Time.deltaTime;
			if(Count <= -2.5f && Count > -5.5)
			{
				transform.Rotate (Vector3.up * (-20 * Time.deltaTime), Space.World);
			}
		}
		else if(Count < -4.5f && Count >= -6.0f)
		{
			transform.Rotate (Vector3.up * (-20 * Time.deltaTime), Space.World);
		}
		else if(Count < -6.0f && Count > -11.0f)
		{
			transform.position += Vector3.forward * 80 * Time.deltaTime;
		}
		else if(Count < -11.0f && Count > -25.0f)
		{
			Enterprise.transform.position -= Vector3.forward * 50 * Time.deltaTime;
		}
		else if(Count < -24.7f && Count > -28.0f)
		{
			particle1.SetActive (true);
			particle2.SetActive (true);
			Enterprise.transform.position -= Vector3.forward * 700 * Time.deltaTime;
			Invoke("MoveEnterprise", 3.0f);
		}
		else if(Count < -32.0f && Count > -34.0f)
		{
			Logo.guiTexture.enabled = false;
			Picard.guiTexture.enabled = true;
		}
		else if(Count < -34.0f && Count > -37.5f)
		{
			Picard.guiTexture.enabled = false;
			Enterprise2.gameObject.SetActive(true);
			Enterprise2.transform.position += Vector3.forward * 150 * Time.deltaTime;
		}
		else if(Count < -37.5f && Count > -42.0f)
		{
			//Picard.guiTexture.enabled = false;
			Enterprise2.gameObject.SetActive(false);
			Enterprise2.transform.position = new Vector3(posEnt1.x, posEnt1.y, posEnt1.z);
			Riker.guiTexture.enabled = true;
		}
		else if(Count < -42.5f && Count > -44.0f)
		{
			Riker.guiTexture.enabled = false;
			LaForge.guiTexture.enabled = true;
		}
		else if(Count < -44.0f && Count > -47.0f)
		{
			LaForge.guiTexture.enabled = false;
			Enterprise3.gameObject.SetActive(true);
			Enterprise3.transform.position += Vector3.forward * 150 * Time.deltaTime;
		}
		else if(Count < -47.5f && Count > -52.0f)
		{
			//LaForge.guiTexture.enabled = false;
			Enterprise3.gameObject.SetActive(false);
			Enterprise3.transform.position = new Vector3(posEnt2.x, posEnt2.y, posEnt2.z);
			Wolf.guiTexture.enabled = true;
		}
		else if(Count < -52.5f && Count > -57.0f)
		{
			Wolf.guiTexture.enabled = false;
			Crusher.guiTexture.enabled = true;
		}
		else if(Count < -57.5f && Count > -59.0f)
		{
			Crusher.guiTexture.enabled = false;
			Troi.guiTexture.enabled = true;
		}
		else if(Count < -59.0f && Count > -62.5f)
		{
			Troi.guiTexture.enabled = false;
			Enterprise2.gameObject.SetActive(true);
			Enterprise2.transform.position += Vector3.forward * 150 * Time.deltaTime;
		}
		else if(Count < -62.5f && Count > -67.0f)
		{
			//Troi.guiTexture.enabled = false;
			Enterprise2.gameObject.SetActive(false);
			Data.guiTexture.enabled = true;
		}
		else if(Count < -67.5f && Count > -72.0f)
		{
			Data.guiTexture.enabled = false;
			Crusher2.guiTexture.enabled = true;
		}
		else if(Count < -72.0f /*&& Count > -62.5f*/)
		{
			Crusher2.guiTexture.enabled = false;
			Enterprise.transform.position -= Vector3.forward * 300 * Time.deltaTime;
			Invoke("LastWarpSpeed",3.0f);
			//Application.LoadLevel(3);
		}
		Invoke ("TurnOffCamera", 28.0f);

		if(Count < -80.0f)
		{
			Application.LoadLevel(3);
		}
	}

	void LastWarpSpeed()
	{
		Enterprise.transform.position -= Vector3.forward * 700 * Time.deltaTime;
	}
	void MoveEnterprise()
	{
		Enterprise.gameObject.SetActive (false);
		Logo.guiTexture.enabled = true;
		if(move)
		{
			Enterprise.transform.position -= Vector3.back * 3000 * Time.deltaTime;
			Invoke("stop", 3.0f);
		}
	}

	void stop()
	{
		move = false;
		Enterprise.gameObject.SetActive (true);
	}

	void TurnOffCamera()
	{
		Planet2.gameObject.SetActive (false);
		Planet1.gameObject.SetActive (false);

		camera1.enabled = false;
		camera2.enabled = true;
	}
}
