using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// This script is used in scene 8
/// Moving ships, setting off explosion, firing laser and bullets and moving cameras
/// 
/// </summary>

public class MoveEnterpriseEntShootingCube : MonoBehaviour 
{
	private float speed = 0.1f, Count = 0.0f, Counter = 0.0f;
	public Texture PicardFires;
	public GameObject NotFire, Fire;
	public bool PicardFireSpeechOver = false, PicardSpeechStart = true;
	public Vector3 pos;
	public Camera Camera1, Camera2, Camera3, Camera4;
	public GameObject laser1, laser2, laser3, laser4, BorgLaser, CloseUpLaser1, CloseUpLaser2, CloseUpLaser3, Explosion1, Explosion2, Explosion3;
	public GameObject BorgSphere, ExplosionA, ExplosionB, ExplosionC, ExplosionD, ExplosionE, BorgSphere2;
	public GameObject FinalExplosion1, FinalExplosion2, FinalExplosion3, FinalExplosion4, finalKaboom, BorgCube;
	public GameObject Defiant1, Defiant2, Defiant3, Bullet1, Bullet2, Bullet3, Bullet4;

	// Use this for initialization
	void Start () 
	{
		// Storing the starting position of the enterprise
		pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Displaying the image of Picard when bool is true
		if(PicardSpeechStart)
		{
			Counter += Time.deltaTime;

			if(Counter > 3.0f)
			{
				PicardFireSpeechOver = true;
				Fire.audio.enabled = false;
				PicardSpeechStart = false;
			}
		}

		// When Picard is over the rest of the scene can carry on. 
		if(PicardFireSpeechOver)
		{
			NotFire.audio.enabled = true;
			Count += Time.deltaTime;
			Debug.Log (Count);

			// Moving the enterprise and the defiants towards the cube
			transform.position += Vector3.forward * speed * Time.deltaTime;
			Defiant1.transform.position += Vector3.forward * speed * Time.deltaTime;
			Defiant2.transform.position += Vector3.forward * speed * Time.deltaTime;

			// The following is a chain of results that are triggered by the counter 
			if(Count > 0.5f && Count <= 0.8f)
			{
				// Firing laser
				laser1.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 1.0f && Count <= 3.0f)
			{
				// Firing bullets with speed
				laser1.gameObject.GetComponent<LineRenderer>().enabled = false;
				Bullet1.gameObject.GetComponent<LineRenderer>().enabled = true;
				Bullet1.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
				Bullet2.gameObject.GetComponent<LineRenderer>().enabled = true;
				Bullet2.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
				Bullet3.gameObject.GetComponent<LineRenderer>().enabled = true;
				Bullet3.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
				Bullet4.gameObject.GetComponent<LineRenderer>().enabled = true;
				Bullet4.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
			}
			else if(Count > 3.0f && Count < 3.5f)
			{
				// Firing more lasers and moving bullets
				Bullet1.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
				Bullet2.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
				Bullet3.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
				Bullet4.transform.position += Vector3.forward * (speed * 5.5f) * Time.deltaTime;
				laser2.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 4.0f && Count <= 4.5f)
			{
				// Turning off bullets and camera switch
				Bullet1.gameObject.GetComponent<LineRenderer>().enabled = false;
				Bullet2.gameObject.GetComponent<LineRenderer>().enabled = false;
				Bullet3.gameObject.GetComponent<LineRenderer>().enabled = false;
				Bullet4.gameObject.GetComponent<LineRenderer>().enabled = false;
				laser2.gameObject.GetComponent<LineRenderer>().enabled = false;
				Defiant1.gameObject.SetActive(false);
				Defiant2.gameObject.SetActive(false);
				Camera1.gameObject.SetActive(false);
			}
			else if(Count > 5.5f && Count <= 5.8f)
			{
				// Fire laser
				laser3.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 6.0f && Count <= 6.5f)
			{
				// Fire borg laser
				BorgLaser.gameObject.GetComponent<LineRenderer>().enabled = true;
				laser3.gameObject.GetComponent<LineRenderer>().enabled = false;
			}
			else if(Count > 6.5f && Count <= 7.0f)
			{
				// Turning off borg laser
				BorgLaser.gameObject.GetComponent<LineRenderer>().enabled = false;
			}
			else if(Count > 7.5f && Count <= 7.8f)
			{
				// Firing lasers
				BorgLaser.gameObject.GetComponent<LineRenderer>().enabled = true;
				laser4.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 7.8f && Count <= 8.0f)
			{
				BorgLaser.gameObject.GetComponent<LineRenderer>().enabled = false;
				laser4.gameObject.GetComponent<LineRenderer>().enabled = false;
			}
			else if(Count > 8.0f && Count <= 8.5f)
			{
				// Camera switch
				Camera3.gameObject.SetActive(true);

			}
			else if(Count > 8.5f && Count <= 9.0f)
			{
				// Laser fired
				CloseUpLaser1.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 9.0f && Count <= 9.5f)
			{
				// Explosion triggered on cube
				Explosion1.gameObject.SetActive(true);
				CloseUpLaser1.gameObject.GetComponent<LineRenderer>().enabled = false;
				CloseUpLaser2.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 9.5f && Count <= 10.0f)
			{
				// Explosion triggered on cube
				Explosion2.gameObject.SetActive(true);
				CloseUpLaser2.gameObject.GetComponent<LineRenderer>().enabled = false;
				CloseUpLaser3.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 10.0f && Count <= 10.1f)
			{
				Explosion1.gameObject.SetActive(false);
				Explosion2.gameObject.SetActive(false);
				Explosion3.gameObject.SetActive(true);
				CloseUpLaser3.gameObject.GetComponent<LineRenderer>().enabled = false;
			}
			else if(Count > 11.0f && Count <= 11.5f)
			{
				// Resetting the position of enterprise 
				// Switching the camera's
				transform.position = new Vector3(pos.x, pos.y, pos.z);
				Camera3.gameObject.SetActive(false);
				Camera1.gameObject.SetActive(true);
				laser1.gameObject.GetComponent<LineRenderer>().enabled = true;
				Defiant3.gameObject.SetActive(true);
				Defiant3.transform.position += Vector3.left * Time.deltaTime * speed;
			}
			else if(Count > 11.5f && Count <= 12.0f)
			{
				laser1.gameObject.GetComponent<LineRenderer>().enabled = false;
				Defiant3.transform.position += Vector3.left * Time.deltaTime * speed;
			}
			else if(Count > 12.0f && Count <= 13.7f)
			{
				Defiant3.transform.position += Vector3.left * Time.deltaTime * speed;
			}
			else if(Count > 13.7f && Count <= 14.0f)
			{
				laser2.gameObject.GetComponent<LineRenderer>().enabled = true;
				Defiant3.transform.position += Vector3.left * Time.deltaTime * speed;
			}
			else if(Count > 14.0f && Count <= 14.5f)
			{
				laser2.gameObject.GetComponent<LineRenderer>().enabled = false;
				Defiant3.transform.position += Vector3.left * Time.deltaTime * speed;
			}
			else if(Count > 14.5f && Count <= 15.0f)
			{
				Defiant3.gameObject.SetActive(false);
				Explosion3.gameObject.SetActive(false);
				Camera3.gameObject.SetActive(true);
				Camera1.gameObject.SetActive(false);
				CloseUpLaser1.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 15.0f && Count <= 15.5f)
			{
				Explosion1.gameObject.SetActive(true);
				CloseUpLaser1.gameObject.GetComponent<LineRenderer>().enabled = false;
				CloseUpLaser2.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 15.5f && Count <= 16.0f)
			{
				Explosion2.gameObject.SetActive(true);
				CloseUpLaser2.gameObject.GetComponent<LineRenderer>().enabled = false;
				CloseUpLaser3.gameObject.GetComponent<LineRenderer>().enabled = true;
			}
			else if(Count > 16.0f && Count <= 16.5f)
			{
				Explosion3.gameObject.SetActive(true);
				CloseUpLaser3.gameObject.GetComponent<LineRenderer>().enabled = false;
			}
			else if(Count > 16.5f && Count <= 20.0f)
			{
				// Moving the borg sphere out of the cube once it starts to explode
				Camera3.gameObject.SetActive(false);
				Camera4.gameObject.SetActive(true); 
				ExplosionA.gameObject.SetActive(true);
				ExplosionB.gameObject.SetActive(true);
				ExplosionC.gameObject.SetActive(true);
				ExplosionD.gameObject.SetActive(true);
				ExplosionE.gameObject.SetActive(true);
				BorgSphere.transform.position += Vector3.right * 0.25f * Time.deltaTime;
			}
			else if(Count > 20.0f && Count <= 23.0f)
			{
				// Switching the camera's
				Camera4.gameObject.SetActive(false);
				BorgSphere.gameObject.SetActive(false);
				BorgSphere2.gameObject.SetActive(true);
				BorgSphere2.transform.position += Vector3.back * 0.25f * Time.deltaTime;
			}
			else if(Count > 23.0f && Count <= 24.0f)
			{
				BorgSphere2.transform.position += Vector3.back * 0.25f * Time.deltaTime;
				FinalExplosion1.gameObject.SetActive(true);
				FinalExplosion2.gameObject.SetActive(true);
				FinalExplosion3.gameObject.SetActive(true);
				FinalExplosion4.gameObject.SetActive(true);
			}
			else if(Count > 24.0f && Count <= 24.5f)
			{
				BorgSphere2.transform.position += Vector3.back * 0.25f * Time.deltaTime;
				FinalExplosion1.gameObject.SetActive(false);
				FinalExplosion2.gameObject.SetActive(false);
				FinalExplosion3.gameObject.SetActive(false);
				FinalExplosion4.gameObject.SetActive(false);
			}
			else if(Count > 24.5f && Count <= 25.0f)
			{
				BorgSphere2.transform.position += Vector3.back * 0.25f * Time.deltaTime;
				FinalExplosion1.gameObject.SetActive(true);
				FinalExplosion2.gameObject.SetActive(true);
				FinalExplosion3.gameObject.SetActive(true);
				FinalExplosion4.gameObject.SetActive(true);
			}
			else if(Count > 25.0f && Count <= 27.0f)
			{
				// Big explosion and removing the borg cube after
				BorgSphere2.transform.position += Vector3.back * 0.25f * Time.deltaTime;
				finalKaboom.gameObject.SetActive(true);
				BorgCube.gameObject.SetActive(false);
			}
			else if(Count > 27.0f && Count <= 28.0f)
			{
				BorgSphere2.gameObject.SetActive(false);
			}
			else if(Count > 30.0f)
			{
				Application.LoadLevel(9);
			}
		}
	}

	void OnGUI()
	{
		if(PicardSpeechStart)
		{
			GUI.DrawTexture (new Rect (0,0, Screen.width, Screen.height), PicardFires);
		}
	}
}
