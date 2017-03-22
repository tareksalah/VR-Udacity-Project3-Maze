using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChestTresure : MonoBehaviour
{

	public Animator myChestAnimator;

	public GameObject doorRef;

	private Door templeDoorRef;

	void Start ()
	{
		templeDoorRef = doorRef.GetComponentInChildren<Door> ();

	}

	void Update ()
	{
		if (!templeDoorRef.doorIsClosed) {
			myChestAnimator.SetTrigger ("OpenChestTrigger");
		}
	}


}
