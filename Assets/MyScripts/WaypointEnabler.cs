using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointEnabler : MonoBehaviour
{

	void Start ()
	{
		gameObject.SetActive (false);
	}


	// Is called from the start button on the entry canvas to activate the waypoints
	public void EnableWaypoints ()
	{
		gameObject.SetActive (true);
	}


}
