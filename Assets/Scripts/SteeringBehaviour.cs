using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using BGE.Geom;

/// <summary>
/// 
/// This script is not been used
/// 
/// </summary>

public class SteeringBehaviour : MonoBehaviour 
{
	public bool Seek, Evade, ObstacleAvoidance, OffsetPursuit, Pursue, Flee, RandomWalk, Wander, Arrive, FollowPath, SphereConstrain = false;
	//public Path path = new Path();
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (FollowPath == true) 
		{
			//followPath();
		}
	}

	/*public Vector3 followPath()
	{
		float epsilon = 5.0f;
		/*float dist = (transform.position - path.NextWaypoint()).magnitude;
		if (dist < epsilon)
		{
			path.AdvanceToNext();
		}
		if ((!path.Looped) && path.IsLast())
		{
			return Arrive(path.NextWaypoint());
		}
		else
		{
			return Seek(path.NextWaypoint());
		}
	}*/
}
