using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	//Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Door door;

	public bool keyCollected = false;

	void Update ()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked ()
	{

		keyCollected = true;

		// Instatiate the KeyPoof Prefab where this key is located
		GameObject keyPoofPrefabClone = (GameObject)Instantiate (keyPoofPrefab, transform.position, transform.rotation);

		keyPoofPrefabClone.GetComponentInChildren<AudioSource> ().Play ();

		Destroy (gameObject);
		door.Unlock ();
//		Debug.Log ("Door Unlock function called");

		// Make sure the poof animates vertically
		// Call the Unlock() method on the Door
		// Set the Key Collected Variable to true
		// Destroy the key. Check the Unity documentation on how to use Destroy
	}

}
