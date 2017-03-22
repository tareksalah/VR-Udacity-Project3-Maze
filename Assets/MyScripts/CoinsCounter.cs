using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{

	public static int coinsCollected = 0;

	public void AddCoin ()
	{
		coinsCollected++;
	}

}
