using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAnimator : MonoBehaviour
{

	public float verticalSpeed = 0.7f;
	public float rotationalSpeed = 5f;

	private Vector3 startPosition;

	void Start ()
	{
		startPosition = transform.position;
	}

	void Update ()
	{
		transform.position = startPosition + new Vector3 (0f, Mathf.Sin (Time.time) * verticalSpeed, 0f);
		transform.Rotate (0f, 0f, Mathf.Sin (Time.time) * rotationalSpeed);
	}
}
