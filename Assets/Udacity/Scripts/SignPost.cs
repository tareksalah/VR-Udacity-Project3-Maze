using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour
{

	public GameObject door;
	public GameObject signPostCanvas;

	private Door templeDoor;
	private	 Text scoreText;

	private int score;


	public void Start ()
	{
		scoreText = GetComponentInChildren<Text> ();
		templeDoor = door.GetComponentInChildren<Door> ();

		signPostCanvas.SetActive (false);

	}


	void Update ()
	{
	
		if (!templeDoor.doorIsClosed) {
			//Display the winning text and show the number of coins collected
			signPostCanvas.SetActive (true);
			score = CoinsCounter.coinsCollected;
			scoreText.text = "You Made it ! \n" + "You collected \n" + score + " out of 10 coins";
	
		}
	}


	public void ResetScene ()
	{
		// Reset the scene when the user clicks the sign post
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}