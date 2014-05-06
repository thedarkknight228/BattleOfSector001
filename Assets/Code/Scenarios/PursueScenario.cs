using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// 
/// This script is being used for scene 8
/// 
/// </summary>

namespace BGE.Scenarios
{
    class PursueScenario : Scenario
    {
        public override string Description()
        {
            return "Pursuit Demo";
        }
        public override void Start()
        {
            Params.Load("default.txt");

			// Setting the inital starting position of the leader ship
            leader = CreateBoid(new Vector3(-87, 2.4f, 386), leaderPrefab);
			// Setting the scale of the ship
			leader.transform.localScale = new Vector3 (0.015f,0.015f,0.015f);
			// Setting the initial starting position of the random walk target
			leader.GetComponent<SteeringBehaviours> ().randomWalkTarget = leader.transform.position;
			leader.GetComponent<SteeringBehaviours> ().RandomWalkEnabled = true;
			leader.GetComponent<SteeringBehaviours> ().ObstacleAvoidanceEnabled = true;

			// The same as above for different ship and different location
			Ship2 = CreateBoid(new Vector3(-85.0f, 2.4f, 386), Ship2Prefab);
			Ship2.transform.localScale = new Vector3 (0.015f,0.015f,0.015f);
			Ship2.GetComponent<SteeringBehaviours> ().randomWalkTarget = Ship2.transform.position;
			Ship2.GetComponent<SteeringBehaviours> ().RandomWalkEnabled = true;
			Ship2.GetComponent<SteeringBehaviours> ().ObstacleAvoidanceEnabled = true;


            //CreateCamFollower(boid, new Vector3(0, 5, -10));
        }
    }
}