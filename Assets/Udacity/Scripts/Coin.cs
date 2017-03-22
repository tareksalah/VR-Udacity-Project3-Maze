using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	//Create a reference to the CoinPoofPrefab
	public GameObject CoinPoofPrefab;

	public void OnCoinClicked ()
	{
		// Instantiating the CoinPoofPrefab at the coin same position and rotation
		GameObject coinPoofPrefabClone = (GameObject)Instantiate (CoinPoofPrefab, transform.position, transform.rotation);

		// Playing the coin clip on the CoinPoofPrefab
		coinPoofPrefabClone.GetComponentInChildren<AudioSource> ().Play ();

		// Increment the coin collector by one each time you click a coin. This will increment the coinsCollected public static variable.
		GetComponentInParent<CoinsCounter> ().AddCoin ();

		// Destroying the coin gameobject
		Destroy (gameObject);

	}

}
