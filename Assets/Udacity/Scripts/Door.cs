using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

	public bool doorIsClosed = true;

	private bool locked = true;
	private bool opening = false;

	public AudioClip[] doorClips;

	public Animator MyDoorAnimator;


	void Update ()
	{

		// Play the door opening animation
		if (opening) {
			MyDoorAnimator.SetTrigger ("openDoor");
			doorIsClosed = false;
		}

	}


	public void OnDoorClicked ()
	{
		// If the door is clicked and unlocked
		// Set the "opening" boolean to true
		// Else
		// Play a sound to indicate the door is locked


		if (!locked) {

			opening = true;

			gameObject.GetComponentInChildren<AudioSource> ().clip = doorClips [1];
			gameObject.GetComponentInChildren<AudioSource> ().Play ();

			//remove the collider so that we can enter the temple
			gameObject.GetComponent<Collider> ().enabled = false;

		} else {
			gameObject.GetComponentInChildren<AudioSource> ().clip = doorClips [0];
			gameObject.GetComponentInChildren<AudioSource> ().Play ();

		}

	}

	public void Unlock ()
	{
		locked = false;
	}


}
