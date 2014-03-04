using UnityEngine;
using System.Collections;

public class MoveEnterprise : MonoBehaviour
{
	float speed = 20;
	public Camera camera1;// = GameObject.FindGameObjectWithTag("MainCamera");
	public Camera camera2; //= GameObject.FindGameObjectWithTag("Camera");
	public GameObject particle1;
	public GameObject particle2;
	// Use this for initialization
	void Start () 
	{
		particle1 = GameObject.FindGameObjectWithTag("EnterpriseParticle1");
		particle1.SetActive (false);
		particle2 = GameObject.FindGameObjectWithTag("EnterpriseParticle2");
		particle2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Invoke ("TurnOffCamera", 5.3f);
		transform.position += Vector3.left * speed * Time.deltaTime;
		Invoke ("WarpSpeed", 7.8f);
		Invoke ("ChangeScene",11);
	}

	void WarpSpeed()
	{
		particle1.SetActive (true);
		particle2.SetActive (true);
		speed += 5;
	}

	void TurnOffCamera()
	{
		camera1.enabled = false;
		camera2.enabled = true;
			//enabled(false);
		//GameObject.Find ("MainCamera").camera.enabled = false;
		//GameObject.Find ("Camera").camera.enabled = true;
	}

	void ChangeScene()
	{
		Application.LoadLevel (4);
	}
}
