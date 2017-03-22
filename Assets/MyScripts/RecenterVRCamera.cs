using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecenterVRCamera : MonoBehaviour
{

	public GvrViewer myGvrViewer;

	void Start ()
	{
		myGvrViewer = GetComponentInParent<GvrViewer> ();
		myGvrViewer.Recenter ();
	}
	
}
