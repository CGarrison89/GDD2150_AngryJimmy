﻿using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		menuScript MenuScript = GetComponent <menuScript> ();
		MenuScript.ExitGame ();
	}

	public void StartLevel()
	{
		Application.LoadLevel ("Scene1");
	}
}
