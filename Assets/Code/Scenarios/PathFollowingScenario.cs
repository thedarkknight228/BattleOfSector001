using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using BGE.Geom;

/// <summary>
/// 
/// This script was changed to add in new way points to suit my scene 6 
/// Then there is an extra ship added to the scene also.
/// All the ships have there own waypoints to move around. 
/// 
/// </summary>

namespace BGE.Scenarios
{
    class PathFollowingScenario : Scenario
    {
        public override string Description()
        {
            return "Path Following Demo";
        }
        static Vector3 initialPos = Vector3.zero;
		static Vector3 initialPos2 = Vector3.zero;
		public float Count = 0.0f;
		private bool exit = false;

        public override void Start()
        {
            Params.Load("default.txt");
	
            leader = CreateBoid(new Vector3(-20, 5, 50), leaderPrefab);
			Ship2 = CreateBoid(new Vector3(-100, 0, 100), Ship2Prefab);
			GameObject ship3 = CreateBoid(new Vector3(-100, 0, 0), Ship2Prefab);

            if (initialPos == Vector3.zero && initialPos2 == Vector3.zero)
            {
                initialPos = leader.transform.position;
				Debug.Log(initialPos);
				initialPos2 = Ship2.transform.position;
            }
            Path path = leader.GetComponent<SteeringBehaviours>().path;
			Path path2 = Ship2.GetComponent<SteeringBehaviours>().path;
			Path path3 = ship3.GetComponent<SteeringBehaviours> ().path;

            leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			Ship2.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos2);

            //path.Waypoints.Add(initialPos + new Vector3(-50, 0, 80));
            //path.Waypoints.Add(initialPos + new Vector3(0, 0, 160));
            //path.Waypoints.Add(initialPos + new Vector3(200, 0, 80));

			path.Waypoints.Add(initialPos + new Vector3(0, 0, 80));
			path.Waypoints.Add(initialPos + new Vector3(20, 0, 120));
			path.Waypoints.Add(initialPos + new Vector3(20, 0, 200));
			path.Waypoints.Add(initialPos + new Vector3(0, 0, 240));
			path.Waypoints.Add(initialPos + new Vector3(0, 0, 320));
			path.Waypoints.Add(initialPos + new Vector3(20, 0, 360));
			path.Waypoints.Add(initialPos + new Vector3(150, 0, 380));
			path.Waypoints.Add(initialPos + new Vector3(150, 0, 0));

            path.Looped = true;
            path.draw = true;
            leader.GetComponent<SteeringBehaviours>().turnOffAll();
			leader.GetComponent<SteeringBehaviours> ().FollowPathEnabled = true;
			leader.GetComponent<SteeringBehaviours> ().ObstacleAvoidanceEnabled = true;

			path2.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 0));
			path2.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 100));
			path2.Waypoints.Add(initialPos2 + new Vector3(-40, 0, 120));
			path2.Waypoints.Add(initialPos2 + new Vector3(-40, 0, 200));
			path2.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 240));
			path2.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 320));
			path2.Waypoints.Add(initialPos2 + new Vector3(-40, 0, 360));
			path2.Waypoints.Add(initialPos2 + new Vector3(-20, 0, 380));
			path2.Waypoints.Add(initialPos2 + new Vector3(40, 0, 0));

			path2.Looped = true;
			path2.draw = true;
			Ship2.GetComponent<SteeringBehaviours>().turnOffAll();
			Ship2.GetComponent<SteeringBehaviours> ().FollowPathEnabled = true;
			Ship2.GetComponent<SteeringBehaviours> ().ObstacleAvoidanceEnabled = true;

			path3.Waypoints.Add(initialPos2 + new Vector3(40, 0, 0));
			path3.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 0));
			path3.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 100));
			path3.Waypoints.Add(initialPos2 + new Vector3(-40, 0, 120));
			path3.Waypoints.Add(initialPos2 + new Vector3(-40, 0, 200));
			path3.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 240));
			path3.Waypoints.Add(initialPos2 + new Vector3(-60, 0, 320));
			path3.Waypoints.Add(initialPos2 + new Vector3(-40, 0, 360));
			path3.Waypoints.Add(initialPos2 + new Vector3(-20, 0, 380));
			path3.Waypoints.Add(initialPos2 + new Vector3(40, 0, 0));
			
			path3.Looped = true;
			path3.draw = true;
			ship3.GetComponent<SteeringBehaviours>().turnOffAll();
			ship3.GetComponent<SteeringBehaviours> ().FollowPathEnabled = true;
			ship3.GetComponent<SteeringBehaviours> ().ObstacleAvoidanceEnabled = true;

			/*int fleetSize = 5;
			float xOff = 12;
			float zOff = -12;
			for (int i = 2; i < fleetSize; i++)
			{
				for (int j = 0; j < i; j++)
				{
					float z = (i - 1) * zOff;
					Vector3 offset = new Vector3((xOff * (-i / 2.0f)) + (j * xOff), 0, z);
					GameObject fleet = CreateBoid(Ship2.transform.position + offset, Ship2Prefab);
					fleet.GetComponent<SteeringBehaviours>().Ship2 = Ship2;
					fleet.GetComponent<SteeringBehaviours>().offset = offset;
					fleet.GetComponent<SteeringBehaviours>().turnOn(SteeringBehaviours.behaviour_type.obstacle_avoidance);
					fleet.GetComponent<SteeringBehaviours>().seekTargetPos = new Vector3(0, 0, 450);
					fleet.GetComponent<SteeringBehaviours>().turnOn(SteeringBehaviours.behaviour_type.offset_pursuit);
					fleet.GetComponent<SteeringBehaviours>().turnOn(SteeringBehaviours.behaviour_type.separation);
					fleet.GetComponent<SteeringBehaviours>().turnOn(SteeringBehaviours.behaviour_type.wall_avoidance);
				}
			}*/
			if (Application.loadedLevel == 5) 
			{
				CreateCamFollower (leader, new Vector3 (0, 50, -70));
			}
			
			GroundEnabled(true);
		}

		public override void Update ()
		{
			Count += Time.deltaTime;
			if(Count >= 5 && !exit)
			{
				Ship2.GetComponent<SteeringBehaviours>().turnOffAll();
				Ship2.SetActive(false);
				Ship2.gameObject.SetActive(false);
				//Ship2.renderer.enabled = false;
				exit = true;
			}
		}
	}
}